using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Product.Commands.Create;
using SignalRApp.Application.Features.Product.Commands.Delete;
using SignalRApp.Application.Features.Product.Commands.Update;
using SignalRApp.Application.Features.Product.Queries.GetProductsWithCategory;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class ProductService(IProductRepository productRepository,IUnitOfWork unitOfWork,IMapper mapper): IProductService
{
    public async Task<Product> GetByIdAsync(int id)
    {
        var product = await productRepository.GetByIdAsync(id);
        if (product is null)
        {
            throw new Exception(ProductConstant.NotFound);
        }

        return product;
    }

    public async Task<List<Product>> GetAllAsync()
    {
        return await productRepository.GetAllAsync();
    }

    public async Task<ServiceResult<List<GetProductsWithCategoryDto>>> GetProductsWithCategoryAsync()
    {
        var productDto =
            mapper.Map<List<GetProductsWithCategoryDto>>(await productRepository.GetAllAsync(x => x.Category));
        return ServiceResult<List<GetProductsWithCategoryDto>>.Success(productDto);
    }

    public async Task<ServiceResult> AddAsync(CreateProductCommandRequest request, CancellationToken cancellationToken)
    {
        var product = mapper.Map<Product>(request);
        await productRepository.AddAsync(product);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateProductCommandRequest request, CancellationToken cancellationToken)
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

    public async Task<ServiceResult> DeleteAsync(DeleteProductCommandRequest request, CancellationToken cancellationToken)
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