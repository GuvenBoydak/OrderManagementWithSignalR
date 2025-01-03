using Microsoft.EntityFrameworkCore;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class GenericRepository<T> : IRepository<T> where T : BaseEntity
{
    protected readonly DbSet<T> _entity;
    private readonly OrderManagementDbContext _context;

    public GenericRepository(OrderManagementDbContext context)
    {
        _context = context;
        _entity = _context.Set<T>();
    }
    
    public async Task<T> GetByIdAsync(int id)
    {
        return await _entity.FindAsync(id);
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _entity.ToListAsync();
    }

    public async ValueTask AddAsync(T entity)
    {
        await _entity.AddAsync(entity);
    }

    public void Update(T entity)
    {
        _entity.Update(entity);
    }

    public void Delete(T entity)
    {
        entity.DeletedDate = DateTime.Now;
        entity.IsDeleted = true;
        _entity.Update(entity);
    }
}