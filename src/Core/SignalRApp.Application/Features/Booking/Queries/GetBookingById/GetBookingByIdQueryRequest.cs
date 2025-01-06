namespace SignalRApp.Application.Features.Booking.Queries.GetBookingById;

public record GetBookingByIdQueryRequest(int Id):IQuery<GetBookingByIdQueryResponse>;