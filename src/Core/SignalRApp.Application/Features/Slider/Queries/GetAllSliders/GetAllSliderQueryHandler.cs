using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Slider.Queries.GetAllSliders;

public class GetAllSliderQueryHandler(ISliderService sliderService):IQueryHandler<GetAllSliderQueryRequest,GetAllSliderQueryResponse>
{
    public async Task<GetAllSliderQueryResponse> Handle(GetAllSliderQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await sliderService.GetAllAsync());
    }
}