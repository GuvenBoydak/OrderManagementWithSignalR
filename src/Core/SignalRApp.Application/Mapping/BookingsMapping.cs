using AutoMapper;
using SignalRApp.Application.Features.Booking.Commands.Create;
using SignalRApp.Application.Features.Booking.Commands.Update;
using SignalRApp.Application.Features.Booking.Queries.GetAllBookings;
using SignalRApp.Application.Features.Booking.Queries.GetBookingById;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class BookingsMapping:Profile
{
    public BookingsMapping()
    {
        CreateMap<Booking, CreateBookingCommandRequest>().ReverseMap();
        CreateMap<Booking, UpdateBookingCommandRequest>().ReverseMap();
        CreateMap<Booking, GetAllBookingsDto>().ReverseMap();
        CreateMap<Booking, GetBookingByIdDto>().ReverseMap();
    }
}