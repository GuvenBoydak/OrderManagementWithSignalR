using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Repository;

public interface IBasketRepository : IRepository<Basket>
{
    Task<List<Basket>> GetBasketByMenuTableId(int id);
}