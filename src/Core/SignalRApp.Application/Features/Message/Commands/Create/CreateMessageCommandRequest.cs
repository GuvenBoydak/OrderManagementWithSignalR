namespace SignalRApp.Application.Features.Message.Commands.Create;

public record CreateMessageCommandRequest(string NameSurname,string Phone,string Email,string Subject,string Content,bool IsRead):ICommand<CreateMessageCommandResponse>;