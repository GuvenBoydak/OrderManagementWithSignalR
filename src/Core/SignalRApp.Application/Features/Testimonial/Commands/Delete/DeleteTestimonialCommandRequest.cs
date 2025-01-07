namespace SignalRApp.Application.Features.Testimonial.Commands.Delete;

public record DeleteTestimonialCommandRequest(int Id):ICommand<DeleteTestimonialCommandResponse>;