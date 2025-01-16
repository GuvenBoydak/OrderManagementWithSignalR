namespace SignalRApp.Application.Features.Notification.Queries.GetNotificationCountByIsRead;

public record GetNotificationCountByIsReadQueryRequest(bool IsRead):IQuery<GetNotificationCountByIsReadQueryResponse>;