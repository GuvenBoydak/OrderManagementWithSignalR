using SignalRApp.Application.Constants;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class BookingService(IBookingRepository bookingRepository,IUnitOfWork unitOfWork): IBookingService
{
    public async Task<Booking> GetByIdAsync(int id)
    {
        var booking = await bookingRepository.GetByIdAsync(id);
        if (booking is null)
        {
            throw new Exception(BookingConstant.NotFound);
        }

        return booking;
    }

    public async Task<List<Booking>> GetAllAsync()
    {
        return await bookingRepository.GetAllAsync();
    }

    public async ValueTask AddAsync(Booking booking,CancellationToken cancellationToken)
    {
        await bookingRepository.AddAsync(booking);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask UpdateAsync(Booking booking,CancellationToken cancellationToken)
    {
        bookingRepository.Update(booking);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask DeleteAsync(Booking booking,CancellationToken cancellationToken)
    {
        bookingRepository.Delete(booking);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}