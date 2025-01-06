using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.About.Commands.Create;
using SignalRApp.Application.Features.About.Commands.Delete;
using SignalRApp.Application.Features.About.Commands.Update;
using SignalRApp.Application.Features.About.Queries.GetAboutById;
using SignalRApp.Application.Features.About.Queries.GetAllAbout;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class AboutService(IAboutRepository aboutRepository,IUnitOfWork unitOfWork,IMapper mapper): IAboutService
{
    public async Task<ServiceResult<GetAboutByIdDto>> GetByIdAsync(int id)
    {
        var about = await aboutRepository.GetByIdAsync(id);
        if (about is null)
        {
            return ServiceResult<GetAboutByIdDto>.Failure(AboutConstant.NotFound);
        }

        var aboutDto = mapper.Map<GetAboutByIdDto>(about);
        return ServiceResult<GetAboutByIdDto>.Success(aboutDto);
    }

    public async Task<ServiceResult<List<GetAllAboutDto>>> GetAllAsync()
    {
        var aboutDto =  mapper.Map<List<GetAllAboutDto>>(await aboutRepository.GetAllAsync());
        return ServiceResult<List<GetAllAboutDto>>.Success(aboutDto);
    }

    public async Task<ServiceResult> AddAsync(CreateAboutCommandRequest request,CancellationToken cancellationToken)
    {
        var about = mapper.Map<About>(request);
        await aboutRepository.AddAsync(about);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateAboutCommandRequest request,CancellationToken cancellationToken)
    {
        var about = await aboutRepository.GetByIdAsync(request.Id);
        if (about is null)
        {
            return ServiceResult.Failure(AboutConstant.NotFound);
        }
        var updatedAbout = mapper.Map(request,about);
        aboutRepository.Update(updatedAbout);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> DeleteAsync(DeleteAboutCommandRequest request,CancellationToken cancellationToken)
    {
        var about = await aboutRepository.GetByIdAsync(request.Id);
        if (about is null)
        {
            return ServiceResult.Failure(AboutConstant.NotFound);
        }
        
        aboutRepository.Delete(about);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}