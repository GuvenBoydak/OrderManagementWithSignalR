using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Repository;

public interface IRepository<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
    ValueTask AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
}