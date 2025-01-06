using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Booking.Queries.GetAllBookings;

public record GetAllBookingsQueryHandler(IBookingService bookingService):IQueryHandler<GetAllBookingsQueryRequest,GetAllBookingsQueryResponse>
{
    public async Task<GetAllBookingsQueryResponse> Handle(GetAllBookingsQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await bookingService.GetAllAsync());
    }
}