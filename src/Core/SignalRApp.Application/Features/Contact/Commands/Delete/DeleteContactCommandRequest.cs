namespace SignalRApp.Application.Features.Contact.Commands.Delete;

public record DeleteContactCommandRequest(int Id):ICommand<DeleteContactCommandResponse>;