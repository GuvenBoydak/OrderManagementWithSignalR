using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Feature.Commands.Create;
using SignalRApp.Application.Features.Feature.Commands.Delete;
using SignalRApp.Application.Features.Feature.Commands.Update;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class FeatureService(IFeatureRepository featureRepository,IUnitOfWork unitOfWork,IMapper mapper): IFeatureService
{
    public async Task<Feature> GetByIdAsync(int id)
    {
        var feature = await featureRepository.GetByIdAsync(id);
        if (feature is null)
        {
            throw new Exception(FeatureConstant.NotFound);
        }

        return feature;
    }

    public async Task<List<Feature>> GetAllAsync()
    {
        return await featureRepository.GetAllAsync();
    }

    public async Task<ServiceResult> AddAsync(CreateFeatureCommandRequest request, CancellationToken cancellationToken)
    {
        var feature = mapper.Map<Feature>(request);
        await featureRepository.AddAsync(feature);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateFeatureCommandRequest request, CancellationToken cancellationToken)
    {
        var feature = await featureRepository.GetByIdAsync(request.Id);
        if (feature is null)
        {
            return ServiceResult.Failure(FeatureConstant.NotFound);
        }

        var updatedFeature = mapper.Map(request, feature);
        featureRepository.Update(updatedFeature);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> DeleteAsync(DeleteFeatureCommandRequest request, CancellationToken cancellationToken)
    {
        var feature = await featureRepository.GetByIdAsync(request.Id);
        if (feature is null)
        {
            return ServiceResult.Failure(FeatureConstant.NotFound);
        }
        
        featureRepository.Delete(feature);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}