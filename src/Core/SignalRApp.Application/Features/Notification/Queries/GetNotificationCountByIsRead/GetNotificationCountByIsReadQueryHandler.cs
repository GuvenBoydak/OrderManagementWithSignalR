using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Notification.Queries.GetNotificationCountByIsRead;

public class GetNotificationCountByIsReadQueryHandler(INotificationService notificationService):IQueryHandler<GetNotificationCountByIsReadQueryRequest,GetNotificationCountByIsReadQueryResponse>
{
    public async Task<GetNotificationCountByIsReadQueryResponse> Handle(GetNotificationCountByIsReadQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await notificationService.GetNotificationCountByIsReadAsync(request.IsRead));
    }
}