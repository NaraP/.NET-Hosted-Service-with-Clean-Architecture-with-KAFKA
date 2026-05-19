using Kafka.Application.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafka.Application.Interfaces.Factories
{
    public class KafkaProcessorFactory : IKafkaProcessorFactory
    {
        private readonly IEnumerable<IKafkaTopicProcessor> _processors;

        public KafkaProcessorFactory(
            IEnumerable<IKafkaTopicProcessor> processors)
        {
            _processors = processors;
        }

        public IKafkaTopicProcessor GetProcessor(string topic)
        {
            return _processors.First(x =>x.TopicName.Equals(topic,StringComparison.OrdinalIgnoreCase));
        }
    }
}
