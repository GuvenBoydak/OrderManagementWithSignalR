using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Booking.Commands.Create;

public class CreateBookingCommandHandler(IBookingService bookingService):ICommandHandler<CreateBookingCommandRequest,CreateBookingCommandResponse>
{
    public async Task<CreateBookingCommandResponse> Handle(CreateBookingCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await bookingService.AddAsync(request,cancellationToken));
    }
}