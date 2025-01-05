using SignalRApp.Application.Features.SocialMedia.Commands.Create;
using SignalRApp.Application.Features.SocialMedia.Commands.Delete;
using SignalRApp.Application.Features.SocialMedia.Commands.Update;
using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface ISocialMediaService
{
    Task<SocialMedia> GetByIdAsync(int id);
    Task<List<SocialMedia>> GetAllAsync();
    Task<ServiceResult> AddAsync(CreateSocialMediaCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateSocialMediaCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteSocialMediaCommandRequest request,CancellationToken cancellationToken);
}