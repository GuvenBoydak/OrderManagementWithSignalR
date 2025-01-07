using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.SocialMedia.Commands.Create;

public class CreateSocialMediaCommandHandler(ISocialMediaService socialMediaService):ICommandHandler<CreateSocialMediaCommandRequest,CreateSocialMediaCommandResponse>
{
    public async Task<CreateSocialMediaCommandResponse> Handle(CreateSocialMediaCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await socialMediaService.AddAsync(request,cancellationToken));
    }
}