using System.Linq.Expressions;
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
    
    public async Task<T> GetByIdAsync(int id,params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = _entity;
        query.Where(x => x.IsDeleted == false);
        if (includes?.Length > 0)
        {
            query = includes.Aggregate(query, (current, include) => current.Include(include));
        }

        return await query.FirstOrDefaultAsync(x=> x.Id == id);
    }

    public async Task<List<T>> GetAllAsync(params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = _entity;
        query.Where(x => x.IsDeleted == false);
        if (includes?.Length > 0)
        {
            query = includes.Aggregate(query, (current, include) => current.Include(include));
        }
        return await query.ToListAsync();
    }

    public async Task<int> GetCountAsync(Expression<Func<T, bool>> predicate = null)
    {
        if (predicate is null)
        {
            return await _entity.CountAsync();
        }
        return await _entity.CountAsync(predicate);
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