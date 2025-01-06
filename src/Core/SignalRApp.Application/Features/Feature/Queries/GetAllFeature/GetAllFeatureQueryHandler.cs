using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Feature.Queries.GetAllFeature;

public class GetAllFeatureQueryHandler(IFeatureService featureService):IQueryHandler<GetAllFeatureQueryRequest,GetAllFeatureQueryResponse>
{
    public async Task<GetAllFeatureQueryResponse> Handle(GetAllFeatureQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await featureService.GetAllAsync());
    }
}