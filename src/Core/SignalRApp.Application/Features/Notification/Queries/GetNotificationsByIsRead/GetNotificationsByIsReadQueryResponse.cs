using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Notification.Queries.GetNotificationsByIsRead;

public record GetNotificationsByIsReadQueryResponse(ServiceResult<List<GetNotificationsByIsReadDto>> Result);