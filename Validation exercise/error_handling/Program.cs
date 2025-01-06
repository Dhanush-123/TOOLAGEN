var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // This adds the required services for controllers

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers(); // Maps the controllers

app.Run();
