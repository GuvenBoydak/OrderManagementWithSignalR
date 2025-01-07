using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.SocialMedia.Queries.GetAllSocialMedia;

public record GetAllSocialMediaQueryResponse(ServiceResult<List<GetAllSocialMediaDto>> Result);