namespace SignalRApp.MvcUI.Models.Response;

public record MessageResponse(int Id,
string NameSurname,
string Phone,
string Email,
string Subject,
string Content,
bool IsRead);