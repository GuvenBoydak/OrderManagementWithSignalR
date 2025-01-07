using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.SocialMedia.Commands.Delete;

public class DeleteSocialMediaCommandHandler(ISocialMediaService socialMediaService):ICommandHandler<DeleteSocialMediaCommandRequest,DeleteSocialMediaCommandResponse>
{
    public async Task<DeleteSocialMediaCommandResponse> Handle(DeleteSocialMediaCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await socialMediaService.DeleteAsync(request,cancellationToken));
    }
}