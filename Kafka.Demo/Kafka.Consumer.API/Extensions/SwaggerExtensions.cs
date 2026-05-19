using Microsoft.OpenApi.Models;

namespace Kafka.Consumer.API.Extensions
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(
                    "v1",
                    new OpenApiInfo
                    {
                        Title = "Kafka Consumer API",
                        Version = "v1",
                        Description =
                            "Kafka Consumer API using .NET 9"
                    });
            });

            return services;
        }
    }
}
