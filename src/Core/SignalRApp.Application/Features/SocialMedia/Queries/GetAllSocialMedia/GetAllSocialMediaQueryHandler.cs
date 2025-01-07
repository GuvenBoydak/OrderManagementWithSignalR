using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.SocialMedia.Queries.GetAllSocialMedia;

public class GetAllSocialMediaQueryHandler(ISocialMediaService socialMediaService):IQueryHandler<GetAllSocialMediaQueryRequest,GetAllSocialMediaQueryResponse>
{
    public async Task<GetAllSocialMediaQueryResponse> Handle(GetAllSocialMediaQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await socialMediaService.GetAllAsync());
    }
}