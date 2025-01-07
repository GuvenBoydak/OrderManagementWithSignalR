namespace SignalRApp.Application.Features.Testimonial.Commands.Update;

public record UpdateTestimonialCommandRequest(int Id,string Name,string Title,string Comment,string ImageUrl,bool Status):ICommand<UpdateTestimonialCommandResponse>;