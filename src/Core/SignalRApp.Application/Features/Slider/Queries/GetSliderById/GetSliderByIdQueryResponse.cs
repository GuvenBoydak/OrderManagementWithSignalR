using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Slider.Queries.GetSliderById;

public record GetSliderByIdQueryResponse(ServiceResult<GetSliderByIdDto> Result);