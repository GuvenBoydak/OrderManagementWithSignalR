using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface ISocialMediaService
{
    Task<SocialMedia> GetByIdAsync(int id);
    Task<List<SocialMedia>> GetAllAsync();
    ValueTask AddAsync(SocialMedia socialMedia,CancellationToken cancellationToken);
    ValueTask UpdateAsync(SocialMedia socialMedia,CancellationToken cancellationToken);
    ValueTask DeleteAsync(SocialMedia socialMedia,CancellationToken cancellationToken);
}