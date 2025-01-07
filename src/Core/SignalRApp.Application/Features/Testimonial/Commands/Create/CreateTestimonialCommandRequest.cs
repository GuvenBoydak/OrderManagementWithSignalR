using SignalRApp.Application.Features.Testimonial.Commands.Update;

namespace SignalRApp.Application.Features.Testimonial.Commands.Create;

public record CreateTestimonialCommandRequest(string Name,string Title,string Comment,string ImageUrl,bool Status):ICommand<CreateTestimonialCommandResponse>;