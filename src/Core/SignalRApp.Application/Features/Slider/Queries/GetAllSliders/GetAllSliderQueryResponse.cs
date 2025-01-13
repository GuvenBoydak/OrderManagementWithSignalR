using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Slider.Queries.GetAllSliders;

public record GetAllSliderQueryResponse(ServiceResult<List<GetAllSliderDto>> Result);