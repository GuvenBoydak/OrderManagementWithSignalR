namespace SignalRApp.Application.Features.Feature.Queries.GetFeaureById;

public record GetFeatureByIdDto(int Id,
    string Title,
    string Description,
    string ImageUrl);