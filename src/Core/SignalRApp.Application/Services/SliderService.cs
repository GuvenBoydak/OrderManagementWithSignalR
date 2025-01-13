using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Slider.Commands.Create;
using SignalRApp.Application.Features.Slider.Commands.Delete;
using SignalRApp.Application.Features.Slider.Commands.Update;
using SignalRApp.Application.Features.Slider.Queries.GetAllSliders;
using SignalRApp.Application.Features.Slider.Queries.GetSliderById;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class SliderService(ISliderRepository sliderRepository,IUnitOfWork unitOfWork,IMapper mapper): ISliderService
{
    public async Task<ServiceResult<GetSliderByIdDto>> GetByIdAsync(int id)
    {
        var slider = await sliderRepository.GetByIdAsync(id);
        if (slider is null)
        {
            return ServiceResult<GetSliderByIdDto>.Failure(SliderConstant.NotFound);
        }

        var sliderDto = mapper.Map<GetSliderByIdDto>(slider);
        return ServiceResult<GetSliderByIdDto>.Success(sliderDto);
    }

    public async Task<ServiceResult<List<GetAllSliderDto>>> GetAllAsync()
    {
        var sliders = await sliderRepository.GetAllAsync();
        return ServiceResult<List<GetAllSliderDto>>
            .Success(mapper.Map<List<GetAllSliderDto>>(sliders));
    }

    public async Task<ServiceResult> AddAsync(CreateSliderCommandRequest request, CancellationToken cancellationToken)
    {
        var slider = mapper.Map<Slider>(request);
        
        await sliderRepository.AddAsync(slider);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateSliderCommandRequest request, CancellationToken cancellationToken)
    {
        var slider = await sliderRepository.GetByIdAsync(request.Id);
        if (slider is null)
        {
            return ServiceResult.Failure(SliderConstant.NotFound);
        }

        var updatedSlider = mapper.Map(request, slider);
        sliderRepository.Update(updatedSlider);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> DeleteAsync(DeleteSliderCommandRequest request, CancellationToken cancellationToken)
    {
        var slider = await sliderRepository.GetByIdAsync(request.Id);
        if (slider is null)
        {
            return ServiceResult.Failure(SliderConstant.NotFound);
        }
        
        sliderRepository.Delete(slider);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}