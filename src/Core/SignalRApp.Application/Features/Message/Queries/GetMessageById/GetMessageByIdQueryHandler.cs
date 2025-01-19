using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Message.Queries.GetMessageById;

public class GetMessageByIdQueryHandler(IMessageService messageService):IQueryHandler<GetMessageByIdQueryRequest,GetMessageByIdQueryResponse>
{
    public async Task<GetMessageByIdQueryResponse> Handle(GetMessageByIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await messageService.GetByIdAsync(request.Id));
    }
}