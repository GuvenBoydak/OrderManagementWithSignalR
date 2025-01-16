using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Notification.Queries.GetAllNotifications;

public class GetAllNotificationsQueryHandler(INotificationService notificationService):IQueryHandler<GetAllNotificationsQueryRequest,GetAllNotificationsQueryResponse>
{
    public async Task<GetAllNotificationsQueryResponse> Handle(GetAllNotificationsQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await notificationService.GetAllAsync());
    }
}