using SignalRApp.Application.Features.Feature.Commands.Create;
using SignalRApp.Application.Features.Feature.Commands.Delete;
using SignalRApp.Application.Features.Feature.Commands.Update;
using SignalRApp.Application.Features.Feature.Queries.GetAllFeature;
using SignalRApp.Application.Features.Feature.Queries.GetFeaureById;
using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IFeatureService
{
    Task<ServiceResult<GetFeatureByIdDto>> GetByIdAsync(int id);
    Task<ServiceResult<List<GetAllFeatureDto>>> GetAllAsync();
    Task<ServiceResult> AddAsync(CreateFeatureCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateFeatureCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteFeatureCommandRequest request,CancellationToken cancellationToken);
}