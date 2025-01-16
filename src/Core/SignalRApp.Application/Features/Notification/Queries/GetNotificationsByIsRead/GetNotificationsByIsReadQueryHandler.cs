using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Notification.Queries.GetNotificationsByIsRead;

public class GetNotificationsByIsReadQueryHandler(INotificationService notificationService):IQueryHandler<GetNotificationsByIsReadQueryRequest,GetNotificationsByIsReadQueryResponse>
{
    public async Task<GetNotificationsByIsReadQueryResponse> Handle(GetNotificationsByIsReadQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await notificationService.GetNotificationsByIsReadAsync(request.isRead));
    }
}