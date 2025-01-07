namespace SignalRApp.Application.Features.SocialMedia.Commands.Create;

public record CreateSocialMediaCommandRequest(string Title,string Url,string Icon):ICommand<CreateSocialMediaCommandResponse>;