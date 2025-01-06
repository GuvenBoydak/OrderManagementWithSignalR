namespace SignalRApp.Application.Features.Booking.Queries.GetBookingById;

public record GetBookingByIdDto(int Id,
    string Name,
    string Phone,
    string Email,
    int PersonCount,
    DateTime Date);