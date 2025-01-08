using AutoMapper;
using SignalRApp.MvcUI.Models.Request.Booking;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.Mapping;

public class BookingMappingProfile:Profile
{
    public BookingMappingProfile()
    {
        CreateMap<BookingResponse, UpdateBookingRequest>().ReverseMap();
    }
}