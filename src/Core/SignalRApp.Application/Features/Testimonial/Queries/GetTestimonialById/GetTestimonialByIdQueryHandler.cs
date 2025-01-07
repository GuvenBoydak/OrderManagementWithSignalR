using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Testimonial.Queries.GetTestimonialById;

public class GetTestimonialByIdQueryHandler(ITestimonialService testimonialService):IQueryHandler<GetTestimonialByIdQueryRequest,GetTestimonialByIdQueryResponse>
{
    public async Task<GetTestimonialByIdQueryResponse> Handle(GetTestimonialByIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await testimonialService.GetByIdAsync(request.Id));
    }
}