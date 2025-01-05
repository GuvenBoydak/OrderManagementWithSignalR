using AutoMapper;
using SignalRApp.Application.Features.Booking.Commands.Create;
using SignalRApp.Application.Features.Booking.Commands.Update;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class BookingsMapping:Profile
{
    public BookingsMapping()
    {
        CreateMap<Booking, CreateBookingCommandRequest>().ReverseMap();
        CreateMap<Booking, UpdateBookingCommandRequest>().ReverseMap();
    }
}