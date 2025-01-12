using Microsoft.EntityFrameworkCore;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Domain.Enums;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class OrderRepository(OrderManagementDbContext context) : GenericRepository<Order>(context), IOrderRepository
{
    public Task<decimal> GetTotalPrice()
    {
        return context.Orders
            .Where(x => x.IsDeleted == false && x.Status == OrderStatus.Checkout)
            .SumAsync(x => x.TotalPrice);
    }

    public Task<decimal> GetTodayTotalPrice()
    {
        return context.Orders
            .Where(x => x.CreatedDate.Date == DateTime.Today && x.IsDeleted == false && x.Status == OrderStatus.Checkout)
            .SumAsync(x => x.TotalPrice);
    }
}