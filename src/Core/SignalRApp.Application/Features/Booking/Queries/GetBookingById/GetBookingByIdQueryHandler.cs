using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Booking.Queries.GetBookingById;

public record GetBookingByIdQueryHandler(IBookingService bookingService):IQueryHandler<GetBookingByIdQueryRequest,GetBookingByIdQueryResponse>
{
    public async Task<GetBookingByIdQueryResponse> Handle(GetBookingByIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await bookingService.GetByIdAsync(request.Id));
    }
}