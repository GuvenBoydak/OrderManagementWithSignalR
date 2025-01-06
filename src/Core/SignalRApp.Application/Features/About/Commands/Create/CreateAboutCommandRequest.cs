namespace SignalRApp.Application.Features.About.Commands.Create;

public record CreateAboutCommandRequest(string Title, string Description,string ImageUrl):ICommand<CreateAboutCommandResponse>;