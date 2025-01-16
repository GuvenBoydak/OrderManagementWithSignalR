namespace SignalRApp.Application.Features.Notification.Queries.GetNotificationsByIsRead;

public record GetNotificationsByIsReadQueryRequest(bool isRead):IQuery<GetNotificationsByIsReadQueryResponse>;