namespace SignalRApp.MvcUI.Models.Response;

public record NotificationResponse(int Id,
    string Description,
    string Type,
    string ImageUrl,
    bool IsRead);