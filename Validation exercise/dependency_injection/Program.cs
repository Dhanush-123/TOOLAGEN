using dependency_injection.Services;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddTransient<ILoggerService, LoggerService>();  // Transient Logger
builder.Services.AddScoped<ILoggerService, LoggerService>();     // Scoped Logger
builder.Services.AddSingleton<ILoggerService, LoggerService>();  // Singleton Logger
builder.Services.AddTransient<IProductService, FakeProductService>();
builder.Services.AddTransient<IAsyncProductService, AsyncProductService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
