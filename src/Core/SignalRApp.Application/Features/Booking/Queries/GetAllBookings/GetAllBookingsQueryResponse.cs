using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Booking.Queries.GetAllBookings;

public record GetAllBookingsQueryResponse(ServiceResult<List<GetAllBookingsDto>> Result);