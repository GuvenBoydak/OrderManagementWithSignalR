using AutoMapper;
using SignalRApp.Application.Features.Feature.Commands.Create;
using SignalRApp.Application.Features.Feature.Commands.Update;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class FeatureMapping:Profile
{
    public FeatureMapping()
    {
        CreateMap<Feature, CreateFeatureCommandRequest>().ReverseMap();
        CreateMap<Feature, UpdateFeatureCommandRequest>().ReverseMap();
    }
}