using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.SocialMedia.Commands.Update;

public class UpdateSocialMediaCommandHandler(ISocialMediaService socialMediaService):ICommandHandler<UpdateSocialMediaCommandRequest,UpdateSocialMediaCommandResponse>
{
    public async Task<UpdateSocialMediaCommandResponse> Handle(UpdateSocialMediaCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await socialMediaService.UpdateAsync(request,cancellationToken));
    }
}