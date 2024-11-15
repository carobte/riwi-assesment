using Assessment_CarolinaBustamante.Config;
using Assessment_CarolinaBustamante.Data;
using Assessment_CarolinaBustamante.Repositories;
using Assessment_CarolinaBustamante.Services;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Database connection

Env.Load();

var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
var dbName = Environment.GetEnvironmentVariable("DB_DATABASE");
var dbUser = Environment.GetEnvironmentVariable("DB_USERNAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

var conectionDB = $"server={dbHost};port={dbPort};database={dbName};uid={dbUser};password={dbPassword}";

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(conectionDB, ServerVersion.Parse("8.0.15-mysql")));

// Add services to the container.

// Utilities
builder.Services.AddSingleton<Utilities>();

// Repositories and services
builder.Services.AddScoped<IUserRepository, UserService>();
builder.Services.AddScoped<IAppointmentRepository, AppointmentService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.Use(async (context, next) =>
{
    if (context.Request.Path == "/")
    {
        var htmlContent = @"
        <html>
            <head>
                <title>Clinic API</title>
            </head>
            <body style='font-family: Arial, sans-serif; background-color: #f4f4f4; text-align: center; height: 90%; display: flex; flex-direction: column; justify-content: center; align-items: center;'>
                <h1 style='color: #333; font-size: 36px;'>Welcome to Clinic API</h1>
                <a href='/swagger' style='color: #007bff; text-decoration: none;'> Click here to Swagger documentation</a>
            </body>
        </html>";

        context.Response.ContentType = "text/html";
        await context.Response.WriteAsync(htmlContent);
    }
    else
    {
        await next();
    }
});

app.MapControllers();

app.Run();
