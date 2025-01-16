using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Notification.Queries.GetNotificationById;

public record GetNotificationByIdQueryResponse(ServiceResult<GetNotificationByIdDto> Result);