using AutoMapper;
using SignalRApp.Application.Features.Contact.Commands.Create;
using SignalRApp.Application.Features.Contact.Commands.Update;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class ContactMapping:Profile
{
    public ContactMapping()
    {
        CreateMap<Contact, CreateContactCommandRequest>().ReverseMap();
        CreateMap<Contact, UpdateContactCommandRequest>().ReverseMap();
    } 
}