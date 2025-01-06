namespace SignalRApp.Application.Features.Booking.Queries.GetAllBookings;

public record GetAllBookingsDto(int Id,
    string Name,
    string Phone,
    string Email,
    int PersonCount,
    DateTime Date);