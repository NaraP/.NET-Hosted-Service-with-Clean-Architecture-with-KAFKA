using Confluent.Kafka;
using Kafka.Application.IServices;
using Polly;
using Polly.Retry;
using System.Diagnostics;

namespace Kafka.Consumer.API.Workers
{
    public class KafkaConsumerWorker : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly ILogger<KafkaConsumerWorker> _logger;
        private readonly IConfiguration _configuration;

        private readonly AsyncRetryPolicy _retryPolicy;

        public KafkaConsumerWorker(
            IServiceScopeFactory scopeFactory,
            ILogger<KafkaConsumerWorker> logger,
            IConfiguration configuration)
        {
            _scopeFactory = scopeFactory;
            _logger = logger;
            _configuration = configuration;

            _retryPolicy = Policy
                .Handle<Exception>()
                .WaitAndRetryAsync(
                    retryCount: 3,
                    sleepDurationProvider: retryAttempt =>
                        TimeSpan.FromSeconds(
                            Math.Pow(2, retryAttempt)),
                    onRetry: (
                        exception,
                        delay,
                        retryCount,
                        context) =>
                    {
                        _logger.LogWarning(
                            exception,
                            "Retry attempt {RetryCount} after {DelaySeconds} seconds",
                            retryCount,
                            delay.TotalSeconds);
                    });
        }

        protected override async Task ExecuteAsync(
            CancellationToken stoppingToken)
        {
            _logger.LogInformation(
                "KafkaConsumerWorker started at {StartedTime}",
                DateTime.UtcNow);

            var config = new ConsumerConfig
            {
                BootstrapServers =
                    _configuration["Kafka:BootstrapServers"],

                GroupId =
                    _configuration["Kafka:GroupId"],

                AutoOffsetReset =
                    AutoOffsetReset.Earliest,

                EnableAutoCommit = false
            };

            _logger.LogInformation(
                "Kafka configuration loaded successfully. BootstrapServers: {BootstrapServers}, GroupId: {GroupId}",
                config.BootstrapServers,
                config.GroupId);

            var topics = new[]
            {
            "workorder-topic",
            "partorder-topic"
            };

            _logger.LogInformation(
                "Kafka topics configured: {Topics}",
                string.Join(", ", topics));

            using var consumer =
                new ConsumerBuilder<Ignore, string>(config)
                .Build();

            consumer.Subscribe(topics);

            _logger.LogInformation(
                "Kafka consumer subscribed successfully");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    _logger.LogDebug(
                        "Waiting for kafka messages...");

                    var result =
                        consumer.Consume(stoppingToken);

                    if (result == null)
                    {
                        _logger.LogWarning(
                            "Received null kafka consume result");

                        continue;
                    }

                    _logger.LogInformation(
                        "Kafka message received. Topic: {Topic}, Partition: {Partition}, Offset: {Offset}",
                        result.Topic,
                        result.Partition.Value,
                        result.Offset.Value);

                    if (string.IsNullOrWhiteSpace(
                        result.Message.Value))
                    {
                        _logger.LogWarning(
                            "Received empty message from Topic: {Topic}",
                            result.Topic);

                        continue;
                    }

                    using var scope =
                        _scopeFactory.CreateScope();

                    _logger.LogDebug(
                        "Dependency injection scope created successfully");

                    var stopwatch =
                        Stopwatch.StartNew();

                    await _retryPolicy.ExecuteAsync(async () =>
                    {
                        _logger.LogInformation(
                            "Started processing message for Topic: {Topic}",
                            result.Topic);

                        await RouteTopicAsync(
                            result.Topic,
                            result.Message.Value,
                            scope.ServiceProvider,
                            stoppingToken);

                        _logger.LogInformation(
                            "Completed processing message for Topic: {Topic}",
                            result.Topic);
                    });

                    stopwatch.Stop();

                    _logger.LogInformation(
                        "Processing completed successfully for Topic: {Topic} in {ElapsedMilliseconds} ms",
                        result.Topic,
                        stopwatch.ElapsedMilliseconds);

                    consumer.Commit(result);

                    _logger.LogInformation(
                        "Kafka offset committed successfully. Topic: {Topic}, Offset: {Offset}",
                        result.Topic,
                        result.Offset.Value);
                }
                catch (ConsumeException ex)
                {
                    _logger.LogError(
                        ex,
                        "Kafka consume exception occurred");
                }
                catch (OperationCanceledException)
                {
                    _logger.LogWarning(
                        "Kafka consumer cancellation requested");

                    break;
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        ex,
                        "Unhandled exception occurred while processing kafka messages");
                }
            }

            _logger.LogInformation(
                "KafkaConsumerWorker stopped at {StoppedTime}",
                DateTime.UtcNow);
        }

        private async Task RouteTopicAsync(string topic, string message, IServiceProvider services, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(topic))
            {
                _logger.LogError(
                    "Kafka topic is empty");

                return;
            }

            var resolver = services.GetRequiredService<IKafkaProcessorResolver>();

            _logger.LogInformation(
                "Resolving processor for topic: {Topic}",
                topic);

            var processor = resolver.Resolve(topic);

            if (processor == null)
            {
                _logger.LogError(
                    "Processor not found for topic: {Topic}",
                    topic);

                return;
            }

            await processor.ProcessAsync(
                message,
                cancellationToken);
        }
    }
}
