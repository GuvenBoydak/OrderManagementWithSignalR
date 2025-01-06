using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Booking.Commands.Update;

public class UpdateBookingCommandHandler(IBookingService bookingService):ICommandHandler<UpdateBookingCommandRequest,UpdateBookingCommandResponse>
{
    public async Task<UpdateBookingCommandResponse> Handle(UpdateBookingCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await bookingService.UpdateAsync(request,cancellationToken));
    }
}