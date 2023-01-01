using MediatR;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.infra.IoC;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.EventHandlers;
using MicroRabbit.Transfer.Domain.Events;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Transfer Microservice", Version = "v1" });
});
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddDbContext<TransferDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TransferDbConnection"));
});

DependancyContainer.RegisterServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

var eventBus = app.Services.GetRequiredService<IEventBus>();
eventBus.Subscribe<TransferCreatedEvent, TransferEventHandler>();

app.Run();
