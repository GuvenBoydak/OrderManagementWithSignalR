using MediatR;

namespace SignalRApp.Application.Features;

public interface IQuery<out TResponse>:IRequest<TResponse>
{
    
}