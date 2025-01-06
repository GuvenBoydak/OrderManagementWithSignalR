using SignalRApp.Application.Features.Booking.Commands.Create;
using SignalRApp.Application.Features.Booking.Commands.Delete;
using SignalRApp.Application.Features.Booking.Commands.Update;
using SignalRApp.Application.Features.Booking.Queries.GetAllBookings;
using SignalRApp.Application.Features.Booking.Queries.GetBookingById;
using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IBookingService
{
    Task<ServiceResult<GetBookingByIdDto>> GetByIdAsync(int id);
    Task<ServiceResult<List<GetAllBookingsDto>>> GetAllAsync();
    Task<ServiceResult> AddAsync(CreateBookingCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateBookingCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteBookingCommandRequest request, CancellationToken cancellationToken);
}