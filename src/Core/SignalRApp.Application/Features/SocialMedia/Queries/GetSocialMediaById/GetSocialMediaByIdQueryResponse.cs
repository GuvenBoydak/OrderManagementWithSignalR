using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.SocialMedia.Queries.GetSocialMediaById;

public record GetSocialMediaByIdQueryResponse(ServiceResult<GetSocialMediaByIdDto> Result);