using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers(); // Adds controller services

var app = builder.Build();

// Configure Middleware

// Exception Handling Middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Show detailed errors in development
}
else
{
    app.UseExceptionHandler("/error"); // Handle exceptions in production
    app.UseHsts(); // Use HTTP Strict Transport Security in production
}

// Logging Middleware
app.Use(async (context, next) =>
{
    var logger = app.Services.GetRequiredService<ILogger<Program>>();
    try
    {
        logger.LogInformation("Processing request {Method} {Path}", context.Request.Method, context.Request.Path);
        await next(); // Pass the request to the next middleware
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "An unhandled exception occurred while processing the request.");
        throw; // Re-throw the exception to let the Exception Handler handle it
    }
});

// Other Middleware
app.UseHttpsRedirection(); // Redirect HTTP to HTTPS
app.UseRouting();          // Enable routing
app.UseAuthorization();    // Enable authorization

// Map Controllers
app.MapControllers();

app.Run();
