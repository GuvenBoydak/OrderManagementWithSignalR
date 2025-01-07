using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.SocialMedia.Commands.Create;
using SignalRApp.Application.Features.SocialMedia.Commands.Delete;
using SignalRApp.Application.Features.SocialMedia.Commands.Update;
using SignalRApp.Application.Features.SocialMedia.Queries.GetAllSocialMedia;
using SignalRApp.Application.Features.SocialMedia.Queries.GetSocialMediaById;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class SocialMediaService(ISocialMediaRepository socialMediaRepository, IUnitOfWork unitOfWork, IMapper mapper)
    : ISocialMediaService
{
    public async Task<ServiceResult<GetSocialMediaByIdDto>> GetByIdAsync(int id)
    {
        var socialMedia = await socialMediaRepository.GetByIdAsync(id);
        if (socialMedia is null)
        {
            return ServiceResult<GetSocialMediaByIdDto>.Failure(SocialMediaConstant.NotFound);
        }

        var socialMediaDto = mapper.Map<GetSocialMediaByIdDto>(socialMedia);
        return ServiceResult<GetSocialMediaByIdDto>.Success(socialMediaDto);
    }

    public async Task<ServiceResult<List<GetAllSocialMediaDto>>> GetAllAsync()
    {
        var socialMedias = await socialMediaRepository.GetAllAsync();
        return ServiceResult<List<GetAllSocialMediaDto>>
            .Success(mapper.Map<List<GetAllSocialMediaDto>>(socialMedias));
    }

    public async Task<ServiceResult> AddAsync(CreateSocialMediaCommandRequest request,
        CancellationToken cancellationToken)
    {
        var socialMedia = mapper.Map<SocialMedia>(request);
        await socialMediaRepository.AddAsync(socialMedia);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateSocialMediaCommandRequest request,
        CancellationToken cancellationToken)
    {
        var socialMedia = await socialMediaRepository.GetByIdAsync(request.Id);
        if (socialMedia is null)
        {
            return ServiceResult.Failure(SocialMediaConstant.NotFound);
        }

        var updatedSocialMedia = mapper.Map(request, socialMedia);
        socialMediaRepository.Update(updatedSocialMedia);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> DeleteAsync(DeleteSocialMediaCommandRequest request,
        CancellationToken cancellationToken)
    {
        var socialMedia = await socialMediaRepository.GetByIdAsync(request.Id);
        if (socialMedia is null)
        {
            return ServiceResult.Failure(SocialMediaConstant.NotFound);
        }

        socialMediaRepository.Delete(socialMedia);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}