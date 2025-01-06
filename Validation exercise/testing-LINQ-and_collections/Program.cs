var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();  // Add support for controllers

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Map Controllers (This allows the DataController to be recognized)
app.MapControllers();

app.Run();
