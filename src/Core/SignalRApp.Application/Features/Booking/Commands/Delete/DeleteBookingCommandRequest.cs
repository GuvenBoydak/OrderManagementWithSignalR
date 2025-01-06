namespace SignalRApp.Application.Features.Booking.Commands.Delete;

public record DeleteBookingCommandRequest(int Id):ICommand<DeleteBookingCommandResponse>;