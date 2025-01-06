using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.About.Queries.GetAllAbout;

public class GetAllAboutQueryHandler(IAboutService aboutService)
    : IQueryHandler<GetAllAboutQueryRequest, GetAllAboutQueryResponse>
{
    public async Task<GetAllAboutQueryResponse> Handle(GetAllAboutQueryRequest request,
        CancellationToken cancellationToken)
    {
        return new(await aboutService.GetAllAsync());
    }
}