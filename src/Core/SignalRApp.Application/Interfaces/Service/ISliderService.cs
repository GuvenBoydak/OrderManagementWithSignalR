using SignalRApp.Application.Features.Slider.Commands.Create;
using SignalRApp.Application.Features.Slider.Commands.Delete;
using SignalRApp.Application.Features.Slider.Commands.Update;
using SignalRApp.Application.Features.Slider.Queries.GetAllSliders;
using SignalRApp.Application.Features.Slider.Queries.GetSliderById;
using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Interfaces.Service;

public interface ISliderService
{
    Task<ServiceResult<GetSliderByIdDto>> GetByIdAsync(int id);
    Task<ServiceResult<List<GetAllSliderDto>>> GetAllAsync();
    Task<ServiceResult> AddAsync(CreateSliderCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateSliderCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteSliderCommandRequest request, CancellationToken cancellationToken);
}