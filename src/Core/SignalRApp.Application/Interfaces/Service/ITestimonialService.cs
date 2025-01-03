using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface ITestimonialService
{
    Task<Testimonial> GetByIdAsync(int id);
    Task<List<Testimonial>> GetAllAsync();
    ValueTask AddAsync(Testimonial testimonial,CancellationToken cancellationToken);
    ValueTask UpdateAsync(Testimonial testimonial,CancellationToken cancellationToken);
    ValueTask DeleteAsync(Testimonial testimonial,CancellationToken cancellationToken);
}