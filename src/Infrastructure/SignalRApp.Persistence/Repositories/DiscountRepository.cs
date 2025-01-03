using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class DiscountRepository(OrderManagementDbContext context)
    : GenericRepository<Discount>(context), IDiscountRepository;