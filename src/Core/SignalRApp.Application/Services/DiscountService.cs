using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Discount.Commands.Create;
using SignalRApp.Application.Features.Discount.Commands.Delete;
using SignalRApp.Application.Features.Discount.Commands.Update;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class DiscountService(IDiscountRepository discountRepository,IUnitOfWork unitOfWork,IMapper mapper): IDiscountService
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

    public async Task<ServiceResult> AddAsync(CreateDiscountCommandRequest request, CancellationToken cancellationToken)
    {
        var discount = mapper.Map<Discount>(request);
        await discountRepository.AddAsync(discount);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateDiscountCommandRequest request, CancellationToken cancellationToken)
    {
        var discount = await discountRepository.GetByIdAsync(request.Id);
        if (discount is null)
        {
            return ServiceResult.Failure(DiscountConstant.NotFound);
        }

        var updatedDiscount = mapper.Map(request, discount);
        discountRepository.Update(updatedDiscount);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> DeleteAsync(DeleteDiscountCommandRequest request, CancellationToken cancellationToken)
    {
        var discount = await discountRepository.GetByIdAsync(request.Id);
        if (discount is null)
        {
            return ServiceResult.Failure(DiscountConstant.NotFound);
        }
        
        discountRepository.Delete(discount);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}