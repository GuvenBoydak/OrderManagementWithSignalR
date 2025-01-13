using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Slider.Queries.GetSliderById;

public class GetSliderByIdQueryHandler(ISliderService sliderService):IQueryHandler<GetSliderByIdQueryRequest,GetSliderByIdQueryResponse>
{
    public async Task<GetSliderByIdQueryResponse> Handle(GetSliderByIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await sliderService.GetByIdAsync(request.Id));
    }
}