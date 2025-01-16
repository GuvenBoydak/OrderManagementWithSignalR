using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Notification.Queries.GetAllNotifications;

public record GetAllNotificationsQueryResponse(ServiceResult<List<GetAllNotificationsDto>> Result);