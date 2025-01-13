using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Slider.Commands.Create;

public class CreateSliderCommandHandler(ISliderService sliderService):ICommandHandler<CreateSliderCommandRequest,CreateSliderCommandResponse>
{
    public async Task<CreateSliderCommandResponse> Handle(CreateSliderCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await sliderService.AddAsync(request,cancellationToken));
    }
}