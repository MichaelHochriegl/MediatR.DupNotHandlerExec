using DupNotHandlerExec.Events;
using MediatR;

namespace DupNotHandlerExec.Handlers;

public class DummyEventHandler<TEvent> : INotificationHandler<TEvent> where TEvent : DummyEvent
{
    private readonly ILogger<DummyEventHandler<TEvent>> _logger;
    private static int _counter = 0;

    public DummyEventHandler(ILogger<DummyEventHandler<TEvent>> logger)
    {
        _logger = logger;
    }
    
    public Task Handle(TEvent notification, CancellationToken cancellationToken)
    {
        _counter++;
        _logger.LogInformation("{handler} executed with count = {counter}", nameof(DummyEventHandler<TEvent>), _counter);
        
        return Task.CompletedTask;
    }
}