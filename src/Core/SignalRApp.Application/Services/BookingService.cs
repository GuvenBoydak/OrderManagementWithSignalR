using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Booking.Commands.Create;
using SignalRApp.Application.Features.Booking.Commands.Delete;
using SignalRApp.Application.Features.Booking.Commands.Update;
using SignalRApp.Application.Features.Booking.Queries.GetAllBookings;
using SignalRApp.Application.Features.Booking.Queries.GetBookingById;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class BookingService(IBookingRepository bookingRepository,IUnitOfWork unitOfWork,IMapper mapper): IBookingService
{
    public async Task<ServiceResult<GetBookingByIdDto>> GetByIdAsync(int id)
    {
        var booking = await bookingRepository.GetByIdAsync(id);
        if (booking is null)
        {
            return ServiceResult<GetBookingByIdDto>.Failure(BookingConstant.NotFound);
        }

        var bookingsDto = mapper.Map<GetBookingByIdDto>(booking);
        return ServiceResult<GetBookingByIdDto>.Success(bookingsDto);
    }

    public async Task<ServiceResult<List<GetAllBookingsDto>>> GetAllAsync()
    {
        var bookings= await bookingRepository.GetAllAsync();
        return ServiceResult<List<GetAllBookingsDto>>
            .Success(mapper.Map<List<GetAllBookingsDto>>(bookings));
    }

    public async Task<ServiceResult> AddAsync(CreateBookingCommandRequest request,CancellationToken cancellationToken)
    {
        var booking = mapper.Map<Booking>(request);
        
        await bookingRepository.AddAsync(booking);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateBookingCommandRequest request,CancellationToken cancellationToken)
    {
        var booking = await bookingRepository.GetByIdAsync(request.Id);
        if (booking is null)
        {
            return ServiceResult.Failure(BookingConstant.NotFound);
        }

        var updatedBooking = mapper.Map(request, booking);
        bookingRepository.Update(updatedBooking);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> DeleteAsync(DeleteBookingCommandRequest request,CancellationToken cancellationToken)
    {
        var booking = await bookingRepository.GetByIdAsync(request.Id);
        if (booking is null)
        {
            return ServiceResult.Failure(BookingConstant.NotFound);
        }
        bookingRepository.Delete(booking);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}