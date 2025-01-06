using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Feature.Queries.GetFeaureById;

public record GetFeatureByIdQueryResponse(ServiceResult<GetFeatureByIdDto> Result);