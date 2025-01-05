using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Category.Commands.Create;
using SignalRApp.Application.Features.Category.Commands.Delete;
using SignalRApp.Application.Features.Category.Commands.Update;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class CategoryService(ICategoryRepository categoryRepository,IUnitOfWork unitOfWork,IMapper mapper): ICategoryService
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

    public async Task<ServiceResult> AddAsync(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        var category = mapper.Map<Category>(request);
        await categoryRepository.AddAsync(category);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        var category = await categoryRepository.GetByIdAsync(request.Id);
        if (category is null)
        {
            return ServiceResult.Failure(CategoryConstant.NotFound);
        }

        var updatedCategory = mapper.Map(request, category);
        categoryRepository.Update(updatedCategory);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> DeleteAsync(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
    {  
        var category = await categoryRepository.GetByIdAsync(request.Id);
        if (category is null)
        {
            return ServiceResult.Failure(CategoryConstant.NotFound);
        }
        
        categoryRepository.Delete(category);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}