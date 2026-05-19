using Kafka.Application.IServices;
using Kafka.Application.Services;
using Kafka.Consumer.API.Workers;
using Kafka.Domain.Entities;
using Kafka.Infrastructure.Repositories;
using Kafka.Infrastructure.Repositories.BcpPartOrder;
using Microsoft.EntityFrameworkCore;

namespace Kafka.Consumer.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }

        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services)
        {
            // Repositories
            services.AddScoped<IRepositoryBcpPartOrder, RepositoryBcpPartOrder>();

            // Kafka Processors
            services.AddScoped<IKafkaTopicProcessor, WorkOrderTopicProcessor>();

            services.AddScoped<IKafkaTopicProcessor, PartOrderTopicProcessor>();

            // Resolver
            services.AddScoped<IKafkaProcessorResolver, KafkaProcessorResolver>();

            // Background Worker
            services.AddHostedService<KafkaConsumerWorker>();

            return services;
        }
    }
}
