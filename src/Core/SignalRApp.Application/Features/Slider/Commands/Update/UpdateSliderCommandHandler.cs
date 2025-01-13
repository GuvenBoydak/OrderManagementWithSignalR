using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Slider.Commands.Update;

public class UpdateSliderCommandHandler(ISliderService sliderService):ICommandHandler<UpdateSliderCommandRequest,UpdateSliderCommandResponse>
{
    public async Task<UpdateSliderCommandResponse> Handle(UpdateSliderCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await sliderService.UpdateAsync(request,cancellationToken));
    }
}