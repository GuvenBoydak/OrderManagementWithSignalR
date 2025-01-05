using MediatR;

namespace SignalRApp.Application.Features;

public interface ICommandHandler<in TCommand,TResponse>:IRequestHandler<TCommand,TResponse> where TCommand:ICommand<TResponse>
{
    
}