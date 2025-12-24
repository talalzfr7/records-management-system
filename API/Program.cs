using API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer("name = DefaultConnection");
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost",
        builder =>
        {
            builder.WithOrigins("http://localhost:51436", "https://localhost:7082") // Add allowed origins
                   .AllowAnyHeader()
                   .AllowAnyMethod()
                   .AllowCredentials();  // Enable credentials if needed
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors("AllowLocalhost");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
