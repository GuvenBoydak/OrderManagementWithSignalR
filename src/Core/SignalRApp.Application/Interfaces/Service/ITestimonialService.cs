using SignalRApp.Application.Features.Testimonial.Commands.Create;
using SignalRApp.Application.Features.Testimonial.Commands.Delete;
using SignalRApp.Application.Features.Testimonial.Commands.Update;
using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface ITestimonialService
{
    Task<Testimonial> GetByIdAsync(int id);
    Task<List<Testimonial>> GetAllAsync();
    Task<ServiceResult> AddAsync(CreateTestimonialCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateTestimonialCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteTestimonialCommandRequest request,CancellationToken cancellationToken);
}