using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.About.Queries.GetAboutById;

public record GetAboutByIdQueryHandler(IAboutService aboutService):IQueryHandler<GetAboutByIdQueryRequest,GetAboutByIdQueryResponse>
{
    public async Task<GetAboutByIdQueryResponse> Handle(GetAboutByIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await aboutService.GetByIdAsync(request.Id));
    }
}