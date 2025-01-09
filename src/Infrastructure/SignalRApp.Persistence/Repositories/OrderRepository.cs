using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class OrderRepository(OrderManagementDbContext context):GenericRepository<Order>(context),IOrderRepository
{
    
}