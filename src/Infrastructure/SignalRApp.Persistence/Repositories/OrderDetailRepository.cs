using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class OrderDetailRepository(OrderManagementDbContext context):GenericRepository<OrderDetail>(context),IOrderDetailRepository
{
    
}