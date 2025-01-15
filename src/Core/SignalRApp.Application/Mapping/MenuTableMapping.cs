using AutoMapper;
using SignalRApp.Application.Dtos;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class MenuTableMapping:Profile
{
    public MenuTableMapping()
    {
        CreateMap<MenuTable, MenuTableDto>().ReverseMap();
    }
}