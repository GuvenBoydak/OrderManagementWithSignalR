using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Testimonial.Commands.Create;

public class CreateTestimonialCommandHandler(ITestimonialService testimonialService):ICommandHandler<CreateTestimonialCommandRequest,CreateTestimonialCommandResponse>
{
    public async Task<CreateTestimonialCommandResponse> Handle(CreateTestimonialCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await testimonialService.AddAsync(request,cancellationToken));
    }
}