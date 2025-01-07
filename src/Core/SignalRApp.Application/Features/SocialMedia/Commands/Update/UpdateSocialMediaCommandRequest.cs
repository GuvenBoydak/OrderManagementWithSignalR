namespace SignalRApp.Application.Features.SocialMedia.Commands.Update;

public record UpdateSocialMediaCommandRequest(int Id,string Title,string Url,string Icon):ICommand<UpdateSocialMediaCommandResponse>;