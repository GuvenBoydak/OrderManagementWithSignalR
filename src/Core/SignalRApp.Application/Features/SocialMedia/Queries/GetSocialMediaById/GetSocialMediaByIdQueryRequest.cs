namespace SignalRApp.Application.Features.SocialMedia.Queries.GetSocialMediaById;

public record GetSocialMediaByIdQueryRequest(int Id):IQuery<GetSocialMediaByIdQueryResponse>;