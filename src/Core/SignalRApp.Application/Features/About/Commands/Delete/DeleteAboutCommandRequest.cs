namespace SignalRApp.Application.Features.About.Commands.Delete;

public record DeleteAboutCommandRequest(int Id) : ICommand<DeleteAboutCommandResponse>;