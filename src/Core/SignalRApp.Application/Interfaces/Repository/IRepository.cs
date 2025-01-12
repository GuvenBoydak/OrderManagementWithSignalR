using System.Linq.Expressions;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Repository;

public interface IRepository<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(int id,params Expression<Func<T, object>>[] includes);
    Task<List<T>> GetAllAsync(params Expression<Func<T, object>>[] includes);
    Task<int> GetCountAsync(Expression<Func<T,bool>> predicate = null);
    ValueTask AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
}