using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Message.Queries.GetAllMessages;

public class GetAllMessagesQueryHandler(IMessageService messageService):IQueryHandler<GetAllMessagesQueryRequest,GetAllMessagesQueryResponse>
{
    public async Task<GetAllMessagesQueryResponse> Handle(GetAllMessagesQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await messageService.GetAllAsync());
    }
}