using DependencyInjectionMethods.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register services option 1
//builder.Services.AddSingleton<IService, ServiceOne>();
//builder.Services.AddSingleton<IService, ServiceTwo>();

// register services option 2
var descriptorOne = new ServiceDescriptor(typeof(IService), typeof(ServiceOne),ServiceLifetime.Singleton);
var descriptorTwo = new ServiceDescriptor(typeof(IService), typeof(ServiceTwo), ServiceLifetime.Singleton);
//builder.Services.TryAddEnumerable(descriptorOne);
//builder.Services.TryAddEnumerable(descriptorTwo);

// This will identify the uniqueness of the combination of service and its implemented class
builder.Services.TryAddEnumerable(new[] {descriptorOne,descriptorTwo}); // above registration also fine

builder.Services.TryAddEnumerable(descriptorTwo); // trying to regiter the same combination, but example 2 api call WONT show this

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
