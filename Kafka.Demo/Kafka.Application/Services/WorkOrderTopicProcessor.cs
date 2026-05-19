using Kafka.Application.Dto;
using Kafka.Application.IServices;
using Kafka.Application.Mapper;
using Kafka.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Kafka.Application.Services
{
    public class WorkOrderTopicProcessor : IKafkaTopicProcessor
    {
        private readonly IRepositoryBcpPartOrder _repositoryBcpPartOrder;
        private readonly ILogger<WorkOrderTopicProcessor> _logger;
        public string TopicName => "workorder-topic";

        public WorkOrderTopicProcessor(
            IRepositoryBcpPartOrder repositoryBcpPartOrder,
            ILogger<WorkOrderTopicProcessor> logger)
        {
            _repositoryBcpPartOrder = repositoryBcpPartOrder;
            _logger = logger;
        }

        public async Task ProcessAsync(string message, CancellationToken cancellationToken)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var data = JsonSerializer.Deserialize<List<BcpPartOrderDto>>(
                message,
                options);

            // Mapper
            var entities = BcpPartOrderMapper.ToEntity(data!);

            // Repository handles insert/update logic
            await _repositoryBcpPartOrder.SaveOrUpdateAsync(entities, cancellationToken);

            _logger.LogInformation("Processed {Count} work orders", entities.Count);
        }
    }
}
