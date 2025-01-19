namespace SignalRApp.Application.Features.Message.Queries.GetAllMessages;

public record GetAllMessagesDto(int Id,
    string NameSurname,
    string Phone,
    string Email,
    string Subject,
    string Content,
    bool IsRead);