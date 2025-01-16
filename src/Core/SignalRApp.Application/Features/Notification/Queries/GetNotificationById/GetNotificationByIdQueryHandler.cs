using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Notification.Queries.GetNotificationById;

public class GetNotificationByIdQueryHandler(INotificationService notificationService)
    : IQueryHandler<GetNotificationByIdQueryRequest, GetNotificationByIdQueryResponse>
{
    public async Task<GetNotificationByIdQueryResponse> Handle(GetNotificationByIdQueryRequest request,
        CancellationToken cancellationToken)
    {
        return new(await notificationService.GetByIdAsync(request.Id));
    }
}