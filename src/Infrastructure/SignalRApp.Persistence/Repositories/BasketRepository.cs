using Microsoft.EntityFrameworkCore;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class BasketRepository(OrderManagementDbContext context)
    : GenericRepository<Basket>(context), IBasketRepository
{
    public async Task<List<Basket>> GetBasketByMenuTableId(int id)
    {
        return await context.Baskets
            .Where(x => x.MenuTableId == id && x.IsDeleted == false)
            .Include(x=>x.MenuTable)
            .Include(x=>x.Product)
            .ToListAsync();
    }
}

