using SignalRApp.Application.Constants;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class AboutService(IAboutRepository aboutRepository,IUnitOfWork unitOfWork): IAboutService
{
    public async Task<About> GetByIdAsync(int id)
    {
        var about = await aboutRepository.GetByIdAsync(id);
        if (about is null)
        {
            throw new Exception(AboutConstant.NotFound);
        }
        return about;
    }

    public async Task<List<About>> GetAllAsync()
    {
        return await aboutRepository.GetAllAsync();
    }

    public async ValueTask AddAsync(About about,CancellationToken cancellationToken)
    {
        await aboutRepository.AddAsync(about);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask UpdateAsync(About about,CancellationToken cancellationToken)
    {
        aboutRepository.Update(about);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask DeleteAsync(About about,CancellationToken cancellationToken)
    {
        aboutRepository.Delete(about);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}