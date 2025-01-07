using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.SocialMedia.Queries.GetSocialMediaById;

public class GetSocialMediaByIdQueryHandler(ISocialMediaService socialMediaService):IQueryHandler<GetSocialMediaByIdQueryRequest,GetSocialMediaByIdQueryResponse>
{
    public async Task<GetSocialMediaByIdQueryResponse> Handle(GetSocialMediaByIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await socialMediaService.GetByIdAsync(request.Id));
    }
}