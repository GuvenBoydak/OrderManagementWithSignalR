using System.Linq.Expressions;
using SignalRApp.Application.Features.Product.Commands.Create;
using SignalRApp.Application.Features.Product.Commands.Delete;
using SignalRApp.Application.Features.Product.Commands.Update;
using SignalRApp.Application.Features.Product.Queries.GetProductById;
using SignalRApp.Application.Features.Product.Queries.GetProductsWithCategory;
using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IProductService
{
    Task<ServiceResult<GetProductByIdDto>> GetByIdAsync(int id);
    Task<ServiceResult<List<GetProductsWithCategoryDto>>> GetProductsWithCategoryAsync();
    Task<ServiceResult<int>> GetCountAsync(Expression<Func<Product, bool>> predicate = null);
    Task<ServiceResult<decimal>> GetProductsAveragePriceAsync();
    Task<ServiceResult<string>> GetProductNameByMaxPriceAsync();
    Task<ServiceResult<string>> ProductNameByMinPriceAsync();
    Task<ServiceResult> AddAsync(CreateProductCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateProductCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteProductCommandRequest request, CancellationToken cancellationToken);
}