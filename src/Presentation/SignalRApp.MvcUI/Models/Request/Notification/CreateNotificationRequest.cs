namespace SignalRApp.MvcUI.Models.Request.Notification;

public record CreateNotificationRequest(string Description,
    string Type,
    string ImageUrl,
    bool IsRead);