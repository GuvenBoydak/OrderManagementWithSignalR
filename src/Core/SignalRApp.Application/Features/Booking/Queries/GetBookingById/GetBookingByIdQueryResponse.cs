using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Booking.Queries.GetBookingById;

public record GetBookingByIdQueryResponse(ServiceResult<GetBookingByIdDto> Result);