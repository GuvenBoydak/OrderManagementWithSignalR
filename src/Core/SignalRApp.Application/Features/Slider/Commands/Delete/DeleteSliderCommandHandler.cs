using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Slider.Commands.Delete;

public class DeleteSliderCommandHandler(ISliderService sliderService):ICommandHandler<DeleteSliderCommandRequest,DeleteSliderCommandResponse>
{
    public async Task<DeleteSliderCommandResponse> Handle(DeleteSliderCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await sliderService.DeleteAsync(request,cancellationToken));
    }
}