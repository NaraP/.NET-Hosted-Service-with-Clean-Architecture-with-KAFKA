using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafka.Application.IServices
{
    public interface IKafkaProcessorResolver
    {
        IKafkaTopicProcessor Resolve(string topic);
    }
}
