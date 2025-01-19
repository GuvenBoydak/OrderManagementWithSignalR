namespace SignalRApp.Application.Features.Message.Commands.Delete;

public record DeleteMessageCommandRequest(int Id):ICommand<DeleteMessageCommandResponse>;