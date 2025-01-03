using SignalRApp.Application.Constants;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class FeatureService(IFeatureRepository featureRepository,IUnitOfWork unitOfWork): IFeatureService
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

    public async ValueTask AddAsync(Feature feature, CancellationToken cancellationToken)
    {
        await featureRepository.AddAsync(feature);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask UpdateAsync(Feature feature, CancellationToken cancellationToken)
    {
        featureRepository.Update(feature);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask DeleteAsync(Feature feature, CancellationToken cancellationToken)
    {
        featureRepository.Delete(feature);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}