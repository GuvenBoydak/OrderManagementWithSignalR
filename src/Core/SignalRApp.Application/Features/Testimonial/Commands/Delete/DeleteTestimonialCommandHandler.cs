using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Testimonial.Commands.Delete;

public class DeleteTestimonialCommandHandler(ITestimonialService testimonialService):ICommandHandler<DeleteTestimonialCommandRequest,DeleteTestimonialCommandResponse>
{
    public async Task<DeleteTestimonialCommandResponse> Handle(DeleteTestimonialCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await testimonialService.DeleteAsync(request,cancellationToken));
    }
}