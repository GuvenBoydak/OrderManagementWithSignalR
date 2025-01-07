using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Testimonial.Queries.GetTestimonialById;

public record GetTestimonialByIdQueryResponse(ServiceResult<GetTestimonialByIdDto> Result);