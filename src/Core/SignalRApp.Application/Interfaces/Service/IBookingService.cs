using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IBookingService
{
    Task<Booking> GetByIdAsync(int id);
    Task<List<Booking>> GetAllAsync();
    ValueTask AddAsync(Booking booking,CancellationToken cancellationToken);
    ValueTask UpdateAsync(Booking booking,CancellationToken cancellationToken);
    ValueTask DeleteAsync(Booking booking,CancellationToken cancellationToken);
}