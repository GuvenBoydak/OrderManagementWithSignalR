using SignalRApp.Application.Constants;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class ProductService(IProductRepository productRepository,IUnitOfWork unitOfWork): IProductService
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

    public async ValueTask AddAsync(Product product, CancellationToken cancellationToken)
    {
        await productRepository.AddAsync(product);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask UpdateAsync(Product product, CancellationToken cancellationToken)
    {
        productRepository.Update(product);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask DeleteAsync(Product product, CancellationToken cancellationToken)
    {
        productRepository.Delete(product);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}