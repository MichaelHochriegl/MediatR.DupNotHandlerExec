using DupNotHandlerExec.Events;
using MediatR;

namespace DupNotHandlerExec.Handlers;

public class DummyDeletedEventHandler : INotificationHandler<DummyDeletedEvent> 
{
private readonly ILogger<DummyDeletedEventHandler> _logger;
private static int _counter = 0;

public DummyDeletedEventHandler(ILogger<DummyDeletedEventHandler> logger)
{
    _logger = logger;
}
    
public Task Handle(DummyDeletedEvent notification, CancellationToken cancellationToken)
{
    _counter++;
    _logger.LogInformation("{handler} executed with count = {counter}", nameof(DummyDeletedEventHandler), _counter);
        
    return Task.CompletedTask;
}
}