namespace SignalRApp.Application.Features.SocialMedia.Commands.Delete;

public record DeleteSocialMediaCommandRequest(int Id):ICommand<DeleteSocialMediaCommandResponse>;