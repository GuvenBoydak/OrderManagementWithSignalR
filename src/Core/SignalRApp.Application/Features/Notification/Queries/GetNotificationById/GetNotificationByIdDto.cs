namespace SignalRApp.Application.Features.Notification.Queries.GetNotificationById;

public record GetNotificationByIdDto(
    int Id,
    string Description,
    string Type,
    string ImageUrl,
    bool IsRead);