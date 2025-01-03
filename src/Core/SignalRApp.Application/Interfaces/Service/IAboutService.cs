using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IAboutService
{
    Task<About> GetByIdAsync(int id);
    Task<List<About>> GetAllAsync();
    ValueTask AddAsync(About about,CancellationToken cancellationToken);
    ValueTask UpdateAsync(About about,CancellationToken cancellationToken);
    ValueTask DeleteAsync(About about,CancellationToken cancellationToken);
}