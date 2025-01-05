using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Testimonial.Commands.Create;
using SignalRApp.Application.Features.Testimonial.Commands.Delete;
using SignalRApp.Application.Features.Testimonial.Commands.Update;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class TestimonialService(ITestimonialRepository testimonialRepository,IUnitOfWork unitOfWork,IMapper mapper): ITestimonialService
{
    public async Task<Testimonial> GetByIdAsync(int id)
    {
        var testimonial = await testimonialRepository.GetByIdAsync(id);
        if (testimonial is null)
        {
            throw new Exception(TestimonialConstant.NotFound);
        }

        return testimonial;
    }

    public async Task<List<Testimonial>> GetAllAsync()
    {
        return await testimonialRepository.GetAllAsync();
    }

    public async Task<ServiceResult> AddAsync(CreateTestimonialCommandRequest request, CancellationToken cancellationToken)
    {
        var testimonial = mapper.Map<Testimonial>(request);
        await testimonialRepository.AddAsync(testimonial);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateTestimonialCommandRequest request, CancellationToken cancellationToken)
    {
        var testimonial = await testimonialRepository.GetByIdAsync(request.Id);
        if (testimonial is null)
        {
            return ServiceResult.Failure(TestimonialConstant.NotFound);
        }

        var updatedTestimonial = mapper.Map(request, testimonial);
        testimonialRepository.Update(updatedTestimonial);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> DeleteAsync(DeleteTestimonialCommandRequest request, CancellationToken cancellationToken)
    {
        var testimonial = await testimonialRepository.GetByIdAsync(request.Id);
        if (testimonial is null)
        {
            return ServiceResult.Failure(TestimonialConstant.NotFound);
        }
        testimonialRepository.Delete(testimonial);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}