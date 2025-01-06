namespace SignalRApp.Application.Features.Feature.Queries.GetFeaureById;

public record GetFeatureByIdQueryRequest(int Id):IQuery<GetFeatureByIdQueryResponse>;