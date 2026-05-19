using Serilog;

namespace Kafka.Consumer.API.Extensions
{
    public static class LoggingExtensions
    {
        public static ConfigureHostBuilder AddSerilogConfiguration(this ConfigureHostBuilder host)
        {
            host.UseSerilog((context, services, configuration) =>
            {
                configuration
                    .ReadFrom.Configuration(
                        context.Configuration)
                    .Enrich.FromLogContext()
                    .Enrich.WithMachineName()
                    .Enrich.WithThreadId();
            });

            return host;
        }
    }
}
