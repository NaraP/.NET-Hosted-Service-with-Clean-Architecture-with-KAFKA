using Kafka.Application.IServices;

namespace Kafka.Application.Services
{
    public class PartOrderTopicProcessor : IKafkaTopicProcessor
    {
        public string TopicName => "partorder-topic";

        public async Task ProcessAsync(string message, CancellationToken cancellationToken)
        {
            Console.WriteLine(
                $"Processing PartOrder: {message}");

            await Task.CompletedTask;
        }
    }
}
