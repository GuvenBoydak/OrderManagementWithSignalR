using MediatR;

namespace SignalRApp.Application.Features;

public interface ICommand<out TResponse>:IRequest<TResponse>
{
    
}