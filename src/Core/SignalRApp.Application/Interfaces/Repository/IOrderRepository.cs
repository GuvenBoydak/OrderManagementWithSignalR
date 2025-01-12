using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Repository;

public interface IOrderRepository:IRepository<Order>
{
    Task<decimal> GetTotalPrice();
    Task<decimal> GetTodayTotalPrice();
}