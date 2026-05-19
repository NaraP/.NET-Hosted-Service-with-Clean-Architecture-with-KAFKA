using Kafka.Application.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafka.Application.Services
{
    public class KafkaProcessorResolver : IKafkaProcessorResolver
    {
        private readonly IReadOnlyDictionary<string,IKafkaTopicProcessor> _processors;

        public KafkaProcessorResolver(IEnumerable<IKafkaTopicProcessor> processors)
        {
            if (processors == null)
            {
                throw new ArgumentNullException(
                    nameof(processors));
            }

            _processors = processors
                .Where(p =>
                    p != null &&
                    !string.IsNullOrWhiteSpace(
                        p.TopicName))
                .GroupBy(
                    p => p.TopicName.Trim(),
                    StringComparer.OrdinalIgnoreCase)
                .ToDictionary(
                    g => g.Key,
                    g => g.First(),
                    StringComparer.OrdinalIgnoreCase);
        }

        public IKafkaTopicProcessor Resolve(string topic)
        {
            if (string.IsNullOrWhiteSpace(topic))
            {
                throw new ArgumentException(
                    "Topic is empty");
            }

            var normalizedTopic = topic.Trim();

            if (_processors.TryGetValue(normalizedTopic, out var processor))
            {
                return processor;
            }

            throw new InvalidOperationException(
                $"No processor registered for topic '{normalizedTopic}'");
        }
    }
}