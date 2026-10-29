
using ExerciseDemo.Application.Interfaces;
using ExerciseDemo.Application.Queries;
using ExerciseDemo.Infrastructure.Caching;
using ExerciseDemo.Infrastructure.Oracle;
using ExerciseDemo.Infrastructure.Repositories;
using ExerciseDemo.Infrastructure.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Caching.Memory;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<OracleConnectionFactory>();
builder.Services.AddScoped<IProductRepository, OracleProductRepository>();
builder.Services.AddScoped<MemoryCacheService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<GetHistoryTicketNotokQueryRequest>();
builder.Services.AddScoped<IValidator<GetHistoryTicketNotokQueryRequest>,GetHistoryTicketNotokQueryRequest.Validator>();
builder.Services.AddMemoryCache();
builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(
        typeof(GetHistoryTicketNotokQueryRequest).Assembly));
builder.Services.AddHttpClient(nameof(JsonPlaceholderService),
    client =>
    {
        client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
    });
builder.Services.AddScoped<IJsonPlaceholderService, JsonPlaceholderService>();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
