namespace SignalRApp.MvcUI.Models.Request.Message;

public record CreateMessageRequest(string NameSurname,
    string Phone,
    string Email,
    string Subject,
    string Content,
    bool IsRead);