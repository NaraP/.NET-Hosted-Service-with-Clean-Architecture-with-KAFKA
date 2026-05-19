namespace Kafka.Application.IServices
{
    public interface IKafkaTopicProcessor
    {
        string TopicName { get; }
        Task ProcessAsync(string message, CancellationToken cancellationToken);
    }
}
