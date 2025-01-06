using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Feature.Queries.GetAllFeature;

public record GetAllFeatureQueryResponse(ServiceResult<List<GetAllFeatureDto>> Result);