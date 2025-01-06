using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Discount.Commands.Create;
using SignalRApp.Application.Features.Discount.Commands.Delete;
using SignalRApp.Application.Features.Discount.Commands.Update;
using SignalRApp.Application.Features.Discount.Queries.GetAllDiscount;
using SignalRApp.Application.Features.Discount.Queries.GetDiscountById;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class DiscountService(IDiscountRepository discountRepository,IUnitOfWork unitOfWork,IMapper mapper): IDiscountService
{
    public async Task<ServiceResult<GetDiscountByIdDto>> GetByIdAsync(int id)
    {
        var discount = await discountRepository.GetByIdAsync(id);
        if (discount is null)
        {
            return ServiceResult<GetDiscountByIdDto>.Failure(DiscountConstant.NotFound);
        }

        var discountDto = mapper.Map<GetDiscountByIdDto>(discount);
        return ServiceResult<GetDiscountByIdDto>.Success(discountDto);
    }

    public async Task<ServiceResult<List<GetAllDiscountDto>>> GetAllAsync()
    {
        var discounts= await discountRepository.GetAllAsync();
        return ServiceResult<List<GetAllDiscountDto>>
            .Success(mapper.Map<List<GetAllDiscountDto>>(discounts));
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