using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class BookingRepository(OrderManagementDbContext context)
    : GenericRepository<Booking>(context), IBookingRepository;