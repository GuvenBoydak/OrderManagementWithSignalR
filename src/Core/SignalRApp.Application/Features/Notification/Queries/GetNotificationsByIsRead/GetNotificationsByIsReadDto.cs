namespace SignalRApp.Application.Features.Notification.Queries.GetNotificationsByIsRead;

public record GetNotificationsByIsReadDto(int Id,
    string Description,
    string Type,
    string ImageUrl,
    bool IsRead);