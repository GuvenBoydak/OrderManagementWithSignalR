using AutoMapper;
using SignalRApp.Application.Features.Feature.Commands.Create;
using SignalRApp.Application.Features.Feature.Commands.Update;
using SignalRApp.Application.Features.Feature.Queries.GetAllFeature;
using SignalRApp.Application.Features.Feature.Queries.GetFeaureById;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class FeatureMapping:Profile
{
    public FeatureMapping()
    {
        CreateMap<Feature, CreateFeatureCommandRequest>().ReverseMap();
        CreateMap<Feature, UpdateFeatureCommandRequest>().ReverseMap();
        CreateMap<Feature, GetAllFeatureDto>().ReverseMap();
        CreateMap<Feature, GetFeatureByIdDto>().ReverseMap();
    }
}