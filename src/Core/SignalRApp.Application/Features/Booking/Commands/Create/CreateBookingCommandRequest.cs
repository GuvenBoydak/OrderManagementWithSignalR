namespace SignalRApp.Application.Features.Booking.Commands.Create;

public record CreateBookingCommandRequest(string Name,
    string Phone,
    string Email,
    int PersonCount,
    DateTime Date):ICommand<CreateBookingCommandResponse>;