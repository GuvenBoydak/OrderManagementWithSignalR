namespace SignalRApp.Application.Features.Notification.Queries.GetAllNotifications;

public record GetAllNotificationsDto(int Id,
    string Description,
    string Type,
    string ImageUrl,
    bool IsRead);