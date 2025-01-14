using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class BasketRepository(OrderManagementDbContext context)
    : GenericRepository<Basket>(context), IBasketRepository;

