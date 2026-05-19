using Kafka.Application.IServices;

namespace Kafka.Application.Interfaces
{
    public interface IKafkaProcessorFactory
    {
        IKafkaTopicProcessor GetProcessor(string topic);
    }
}
