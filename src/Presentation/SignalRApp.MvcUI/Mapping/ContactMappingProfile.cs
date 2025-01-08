using AutoMapper;
using SignalRApp.MvcUI.Models.Request.Contact;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.Mapping;

public class ContactMappingProfile:Profile
{
    public ContactMappingProfile()
    {
        CreateMap<ContactResponse, UpdateContactRequest>().ReverseMap();
    }
}