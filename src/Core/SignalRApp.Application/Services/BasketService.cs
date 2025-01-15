using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Basket.Commands.Create;
using SignalRApp.Application.Features.Basket.Commands.Delete;
using SignalRApp.Application.Features.Basket.Commands.Update;
using SignalRApp.Application.Features.Basket.Queries.GetAllBaskets;
using SignalRApp.Application.Features.Basket.Queries.GetBasketById;
using SignalRApp.Application.Features.Basket.Queries.GetBasketByMenuTableId;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class BasketService(IBasketRepository basketRepository, IUnitOfWork unitOfWork, IMapper mapper) : IBasketService
{
    public async Task<ServiceResult<GetBasketByIdDto>> GetByIdAsync(int id)
    {
        var basket = await basketRepository.GetByIdAsync(id);
        if (basket is null)
        {
            return ServiceResult<GetBasketByIdDto>.Failure(BasketConstant.NotFound);
        }

        var basketDto = mapper.Map<GetBasketByIdDto>(basket);
        return ServiceResult<GetBasketByIdDto>.Success(basketDto);
    }

    public async Task<ServiceResult<List<GetAllBasketDto>>> GetAllAsync()
    {
        var baskets = await basketRepository.GetAllAsync(x => x.Product, x => x.MenuTable);
        return ServiceResult<List<GetAllBasketDto>>
            .Success(mapper.Map<List<GetAllBasketDto>>(baskets));
    }

    public async Task<ServiceResult<List<GetBasketByMenuTableIdDto>>> GetBasketByMenuTableIdAsync(int id)
    {
        var basket = await basketRepository.GetBasketByMenuTableId(id);
        if (basket is null)
        {
            return ServiceResult<List<GetBasketByMenuTableIdDto>>.Failure(BasketConstant.NotFound);
        }

        var basketDto = mapper.Map<List<GetBasketByMenuTableIdDto>>(basket);
        return ServiceResult<List<GetBasketByMenuTableIdDto>>.Success(basketDto);
    }

    public async Task<ServiceResult> AddAsync(CreateBasketCommandRequest request, CancellationToken cancellationToken)
    {
        var basket = mapper.Map<Basket>(request);

        await basketRepository.AddAsync(basket);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateBasketCommandRequest request,
        CancellationToken cancellationToken)
    {
        var basket = await basketRepository.GetByIdAsync(request.Id);
        if (basket is null)
        {
            return ServiceResult.Failure(BasketConstant.NotFound);
        }

        var updatedBasket = mapper.Map(request, basket);
        basketRepository.Update(updatedBasket);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> DeleteAsync(DeleteBasketCommandRequest request,
        CancellationToken cancellationToken)
    {
        var basket = await basketRepository.GetByIdAsync(request.Id);
        if (basket is null)
        {
            return ServiceResult.Failure(BasketConstant.NotFound);
        }

        basketRepository.Delete(basket);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}