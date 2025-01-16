namespace SignalRApp.Application.Features.Notification.Queries.GetNotificationById;

public record GetNotificationByIdQueryRequest(int Id) : IQuery<GetNotificationByIdQueryResponse>;