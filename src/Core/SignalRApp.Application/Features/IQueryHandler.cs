using MediatR;

namespace SignalRApp.Application.Features;

public interface IQueryHandler<in TQuery,TResponse>:IRequestHandler<TQuery,TResponse> where TQuery:IQuery<TResponse>
{
    
}