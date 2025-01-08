namespace SignalRApp.MvcUI.Models.Request.Testimonial;

public record UpdateTestimonialRequest(int Id,string Name,string Title,string Comment,string ImageUrl,bool Status);