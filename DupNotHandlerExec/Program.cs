using DupNotHandlerExec.Events;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

var app = builder.Build();
app.UseSwagger();

app.MapGet("/", () => "Hello World!");
app.MapGet("/createDummy", (IPublisher publisher) =>
{
    publisher.Publish(new DummyCreatedEvent());
});
app.MapGet("/deleteDummy", (IPublisher publisher) =>
{
    publisher.Publish(new DummyDeletedEvent());
});
app.MapGet("/dummy", (IPublisher publisher) =>
{
    publisher.Publish(new DummyEvent());
});

app.UseSwaggerUI();

app.Run();