using SignalRApp.Application.Constants;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class SocialMediaService(ISocialMediaRepository socialMediaRepository,IUnitOfWork unitOfWork): ISocialMediaService
{
    public async Task<SocialMedia> GetByIdAsync(int id)
    {
        var socialMedia = await socialMediaRepository.GetByIdAsync(id);
        if (socialMedia is null)
        {
            throw new Exception(SocialMediaConstant.NotFound);
        }

        return socialMedia;
    }

    public async Task<List<SocialMedia>> GetAllAsync()
    {
        return await socialMediaRepository.GetAllAsync();
    }

    public async ValueTask AddAsync(SocialMedia socialMedia, CancellationToken cancellationToken)
    {
        await socialMediaRepository.AddAsync(socialMedia);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask UpdateAsync(SocialMedia socialMedia, CancellationToken cancellationToken)
    {
        socialMediaRepository.Update(socialMedia);
        await unitOfWork.SaveChangesAsync(cancellationToken);;
    }

    public async ValueTask DeleteAsync(SocialMedia socialMedia, CancellationToken cancellationToken)
    {
        socialMediaRepository.Delete(socialMedia);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}