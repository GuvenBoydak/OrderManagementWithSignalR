namespace SignalRApp.Application.Features.About.Queries.GetAboutById;

public record GetAboutByIdQueryRequest(int Id):IQuery<GetAboutByIdQueryResponse>;