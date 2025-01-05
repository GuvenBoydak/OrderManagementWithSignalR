using SignalRApp.Application.Features.Booking.Commands.Create;
using SignalRApp.Application.Features.Booking.Commands.Delete;
using SignalRApp.Application.Features.Booking.Commands.Update;
using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IBookingService
{
    Task<Booking> GetByIdAsync(int id);
    Task<List<Booking>> GetAllAsync();
    Task<ServiceResult> AddAsync(CreateBookingCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateBookingCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteBookingCommandRequest request, CancellationToken cancellationToken);
}