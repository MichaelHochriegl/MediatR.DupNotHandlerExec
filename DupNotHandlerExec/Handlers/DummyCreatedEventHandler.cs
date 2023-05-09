using DupNotHandlerExec.Events;
using MediatR;

namespace DupNotHandlerExec.Handlers;

public class DummyCreatedEventHandler : INotificationHandler<DummyCreatedEvent> 
{
private readonly ILogger<DummyCreatedEventHandler> _logger;
private static int _counter = 0;

public DummyCreatedEventHandler(ILogger<DummyCreatedEventHandler> logger)
{
    _logger = logger;
}
    
public Task Handle(DummyCreatedEvent notification, CancellationToken cancellationToken)
{
    _counter++;
    _logger.LogInformation("{handler} executed with count = {counter}", nameof(DummyCreatedEventHandler), _counter);
        
    return Task.CompletedTask;
}
}