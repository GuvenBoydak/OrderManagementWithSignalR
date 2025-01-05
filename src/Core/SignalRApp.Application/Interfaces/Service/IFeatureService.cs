using SignalRApp.Application.Features.Feature.Commands.Create;
using SignalRApp.Application.Features.Feature.Commands.Delete;
using SignalRApp.Application.Features.Feature.Commands.Update;
using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IFeatureService
{
    Task<Feature> GetByIdAsync(int id);
    Task<List<Feature>> GetAllAsync();
    Task<ServiceResult> AddAsync(CreateFeatureCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateFeatureCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteFeatureCommandRequest request,CancellationToken cancellationToken);
}