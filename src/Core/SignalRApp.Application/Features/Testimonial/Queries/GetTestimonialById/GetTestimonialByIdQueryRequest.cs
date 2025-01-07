namespace SignalRApp.Application.Features.Testimonial.Queries.GetTestimonialById;

public record GetTestimonialByIdQueryRequest(int Id):IQuery<GetTestimonialByIdQueryResponse>;