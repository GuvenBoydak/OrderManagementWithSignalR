using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Feature.Queries.GetFeaureById;

public class GetFeatureByIdQueryHandler(IFeatureService featureService):IQueryHandler<GetFeatureByIdQueryRequest,GetFeatureByIdQueryResponse>
{
    public async Task<GetFeatureByIdQueryResponse> Handle(GetFeatureByIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await featureService.GetByIdAsync(request.Id));
    }
}