using SignalRApp.Application.Features.SocialMedia.Commands.Create;
using SignalRApp.Application.Features.SocialMedia.Commands.Delete;
using SignalRApp.Application.Features.SocialMedia.Commands.Update;
using SignalRApp.Application.Features.SocialMedia.Queries.GetAllSocialMedia;
using SignalRApp.Application.Features.SocialMedia.Queries.GetSocialMediaById;
using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface ISocialMediaService
{
    Task<ServiceResult<GetSocialMediaByIdDto>> GetByIdAsync(int id);
    Task<ServiceResult<List<GetAllSocialMediaDto>>> GetAllAsync();
    Task<ServiceResult> AddAsync(CreateSocialMediaCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateSocialMediaCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteSocialMediaCommandRequest request,CancellationToken cancellationToken);
}