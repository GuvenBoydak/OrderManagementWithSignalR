namespace SignalRApp.MvcUI.Models.Request.Notification;

public record UpdateNotificationRequest(int Id,
    string Description,
    string Type,
    string ImageUrl,
    bool IsRead);