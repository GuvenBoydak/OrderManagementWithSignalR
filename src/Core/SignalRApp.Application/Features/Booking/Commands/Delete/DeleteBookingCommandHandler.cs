using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Booking.Commands.Delete;

public class DeleteBookingCommandHandler(IBookingService bookingService):ICommandHandler<DeleteBookingCommandRequest,DeleteBookingCommandResponse>
{
    public async Task<DeleteBookingCommandResponse> Handle(DeleteBookingCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await bookingService.DeleteAsync(request,cancellationToken));
    }
}