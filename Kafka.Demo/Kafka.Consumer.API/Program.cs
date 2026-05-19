using Kafka.Consumer.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Logging
builder.Host.AddSerilogConfiguration();

// Services
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddApplicationServices();
builder.Services.AddSwaggerDocumentation();
builder.Services.AddControllers();

var app = builder.Build();

// Middleware
app.UseCustomMiddleware();

await app.RunAsync();
