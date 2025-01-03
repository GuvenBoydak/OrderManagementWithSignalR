using SignalRApp.Application.Constants;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class CategoryService(ICategoryRepository categoryRepository,IUnitOfWork unitOfWork): ICategoryService
{
    public async Task<Category> GetByIdAsync(int id)
    {
        var category = await categoryRepository.GetByIdAsync(id);
        if (category is null)
        {
            throw new Exception(CategoryConstant.NotFound);
        }

        return category;
    }

    public async Task<List<Category>> GetAllAsync()
    {
        return await categoryRepository.GetAllAsync();
    }

    public async ValueTask AddAsync(Category category, CancellationToken cancellationToken)
    {
        await categoryRepository.AddAsync(category);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask UpdateAsync(Category category, CancellationToken cancellationToken)
    {
        categoryRepository.Update(category);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask DeleteAsync(Category category, CancellationToken cancellationToken)
    {
        categoryRepository.Delete(category);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}