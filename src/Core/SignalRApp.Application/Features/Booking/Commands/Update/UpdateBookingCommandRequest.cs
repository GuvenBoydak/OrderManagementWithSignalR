namespace SignalRApp.Application.Features.Booking.Commands.Update;

public record UpdateBookingCommandRequest(
    int Id,
    string Name,
    string Phone,
    string Email,
    int PersonCount,
    DateTime Date) : ICommand<UpdateBookingCommandResponse>;