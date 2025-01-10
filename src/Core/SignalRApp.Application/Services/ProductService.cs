using System.Linq.Expressions;
using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Category.Queries.GetAllCategories;
using SignalRApp.Application.Features.Category.Queries.GetCategoryById;
using SignalRApp.Application.Features.Product.Commands.Create;
using SignalRApp.Application.Features.Product.Commands.Delete;
using SignalRApp.Application.Features.Product.Commands.Update;
using SignalRApp.Application.Features.Product.Queries.GetProductById;
using SignalRApp.Application.Features.Product.Queries.GetProductsWithCategory;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork, IMapper mapper)
    : IProductService
{
    public async Task<ServiceResult<GetProductByIdDto>> GetByIdAsync(int id)
    {
        var product = await productRepository.GetByIdAsync(id, x => x.Category);
        if (product is null)
        {
            return ServiceResult<GetProductByIdDto>.Failure(ProductConstant.NotFound);
        }

        var productDto = mapper.Map<GetProductByIdDto>(product);

        return ServiceResult<GetProductByIdDto>.Success(productDto);
    }

    public async Task<ServiceResult<List<GetProductsWithCategoryDto>>> GetProductsWithCategoryAsync()
    {
        var products = await productRepository.GetAllAsync(x => x.Category);
        var productDto =
            mapper.Map<List<GetProductsWithCategoryDto>>(products);
        return ServiceResult<List<GetProductsWithCategoryDto>>.Success(productDto);
    }

    public async Task<ServiceResult<int>> GetCountAsync(Expression<Func<Product, bool>> predicate = null)
    {
        if (predicate is null)
        {
            return ServiceResult<int>.Success(await productRepository.GetCountAsync());
        }

        return ServiceResult<int>.Success(await productRepository.GetCountAsync(predicate));
    }

    public async Task<ServiceResult<decimal>> GetProductsAveragePriceAsync()
    {
        return ServiceResult<decimal>.Success(await productRepository.GetProductsAveragePriceAsync());
    }

    public async Task<ServiceResult<string>> GetProductNameByMaxPriceAsync()
    {
        return ServiceResult<string>.Success(await productRepository.GetProductNameByMaxPriceAsync());
    }

    public async Task<ServiceResult<string>> ProductNameByMinPriceAsync()
    {
        return ServiceResult<string>.Success(await productRepository.ProductNameByMinPriceAsync());
    }

    public async Task<ServiceResult> AddAsync(CreateProductCommandRequest request, CancellationToken cancellationToken)
    {
        var product = mapper.Map<Product>(request);
        await productRepository.AddAsync(product);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateProductCommandRequest request,
        CancellationToken cancellationToken)
    {
        var product = await productRepository.GetByIdAsync(request.Id);
        if (product is null)
        {
            return ServiceResult.Failure(ProductConstant.NotFound);
        }

        var updatedProduct = mapper.Map(request, product);
        productRepository.Update(product);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> DeleteAsync(DeleteProductCommandRequest request,
        CancellationToken cancellationToken)
    {
        var product = await productRepository.GetByIdAsync(request.Id);
        if (product is null)
        {
            return ServiceResult.Failure(ProductConstant.NotFound);
        }

        productRepository.Delete(product);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}