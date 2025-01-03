using SignalRApp.Application.Constants;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class TestimonialService(ITestimonialRepository testimonialRepository,IUnitOfWork unitOfWork): ITestimonialService
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

    public async ValueTask AddAsync(Testimonial testimonial, CancellationToken cancellationToken)
    {
        await testimonialRepository.AddAsync(testimonial);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask UpdateAsync(Testimonial testimonial, CancellationToken cancellationToken)
    {
        testimonialRepository.Update(testimonial);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask DeleteAsync(Testimonial testimonial, CancellationToken cancellationToken)
    {
        testimonialRepository.Delete(testimonial);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}