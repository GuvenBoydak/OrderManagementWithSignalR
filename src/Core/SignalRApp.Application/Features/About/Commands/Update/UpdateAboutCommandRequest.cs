namespace SignalRApp.Application.Features.About.Commands.Update;

public record UpdateAboutCommandRequest(int Id,string Title, string Description,string ImageUrl):ICommand<UpdateAboutCommandResponse>;