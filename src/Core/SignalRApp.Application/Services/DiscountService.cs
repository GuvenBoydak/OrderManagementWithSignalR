using SignalRApp.Application.Constants;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class DiscountService(IDiscountRepository discountRepository,IUnitOfWork unitOfWork): IDiscountService
{
    public async Task<Discount> GetByIdAsync(int id)
    {
        var discount = await discountRepository.GetByIdAsync(id);
        if (discount is null)
        {
            throw new Exception(DiscountConstant.NotFound);
        }

        return discount;
    }

    public async Task<List<Discount>> GetAllAsync()
    {
        return await discountRepository.GetAllAsync();
    }

    public async ValueTask AddAsync(Discount discount, CancellationToken cancellationToken)
    {
        await discountRepository.AddAsync(discount);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask UpdateAsync(Discount discount, CancellationToken cancellationToken)
    {
        discountRepository.Update(discount);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask DeleteAsync(Discount discount, CancellationToken cancellationToken)
    {
        discountRepository.Delete(discount);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}