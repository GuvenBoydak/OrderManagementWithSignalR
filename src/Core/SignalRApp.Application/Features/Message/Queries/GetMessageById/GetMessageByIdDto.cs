namespace SignalRApp.Application.Features.Message.Queries.GetMessageById;

public record GetMessageByIdDto(int Id,
    string NameSurname,
    string Phone,
    string Email,
    string Subject,
    string Content,
    bool IsRead);