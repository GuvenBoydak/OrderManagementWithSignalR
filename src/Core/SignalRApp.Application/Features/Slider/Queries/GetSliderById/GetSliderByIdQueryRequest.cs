namespace SignalRApp.Application.Features.Slider.Queries.GetSliderById;

public record GetSliderByIdQueryRequest(int Id):IQuery<GetSliderByIdQueryResponse>;