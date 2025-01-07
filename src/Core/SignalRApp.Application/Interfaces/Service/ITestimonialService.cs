using SignalRApp.Application.Features.Testimonial.Commands.Create;
using SignalRApp.Application.Features.Testimonial.Commands.Delete;
using SignalRApp.Application.Features.Testimonial.Commands.Update;
using SignalRApp.Application.Features.Testimonial.Queries.GetAllTestimonial;
using SignalRApp.Application.Features.Testimonial.Queries.GetTestimonialById;
using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface ITestimonialService
{
    Task<ServiceResult<GetTestimonialByIdDto>> GetByIdAsync(int id);
    Task<ServiceResult<List<GetAllTestimonialDto>>> GetAllAsync();
    Task<ServiceResult> AddAsync(CreateTestimonialCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateTestimonialCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteTestimonialCommandRequest request,CancellationToken cancellationToken);
}