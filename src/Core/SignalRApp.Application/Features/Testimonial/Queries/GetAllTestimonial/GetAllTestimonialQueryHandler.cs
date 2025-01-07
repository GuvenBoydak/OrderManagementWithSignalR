using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Testimonial.Queries.GetAllTestimonial;

public class GetAllTestimonialQueryHandler(ITestimonialService testimonialService):IQueryHandler<GetAllTestimonialQueryRequest,GetAllTestimonialQueryResponse>
{
    public async Task<GetAllTestimonialQueryResponse> Handle(GetAllTestimonialQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await testimonialService.GetAllAsync());
    }
}