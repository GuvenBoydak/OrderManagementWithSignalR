using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Testimonial.Queries.GetAllTestimonial;

public record GetAllTestimonialQueryResponse(ServiceResult<List<GetAllTestimonialDto>> Result);