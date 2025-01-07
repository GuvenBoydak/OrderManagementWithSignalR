using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Testimonial.Commands.Update;

public class UpdateTestimonialCommandHandler(ITestimonialService testimonialService):ICommandHandler<UpdateTestimonialCommandRequest,UpdateTestimonialCommandResponse>
{
    public async Task<UpdateTestimonialCommandResponse> Handle(UpdateTestimonialCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await testimonialService.UpdateAsync(request,cancellationToken));
    }
}