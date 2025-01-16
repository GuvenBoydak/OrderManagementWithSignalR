using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Notification.Queries.GetNotificationCountByIsRead;

public record GetNotificationCountByIsReadQueryResponse(ServiceResult<int> Result);