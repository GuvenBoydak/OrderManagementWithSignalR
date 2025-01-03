using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IFeatureService
{
    Task<Feature> GetByIdAsync(int id);
    Task<List<Feature>> GetAllAsync();
    ValueTask AddAsync(Feature feature,CancellationToken cancellationToken);
    ValueTask UpdateAsync(Feature feature,CancellationToken cancellationToken);
    ValueTask DeleteAsync(Feature feature,CancellationToken cancellationToken);
}