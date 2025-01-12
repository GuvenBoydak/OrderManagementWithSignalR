using System.Linq.Expressions;
using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Category.Commands.Create;
using SignalRApp.Application.Features.Category.Commands.Delete;
using SignalRApp.Application.Features.Category.Commands.Update;
using SignalRApp.Application.Features.Category.Queries.GetAllCategories;
using SignalRApp.Application.Features.Category.Queries.GetCategoryById;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, IMapper mapper)
    : ICategoryService
{
    public async Task<ServiceResult<GetCategoryByIdDto>> GetByIdAsync(int id)
    {
        var category = await categoryRepository.GetByIdAsync(id);
        if (category is null)
        {
            return ServiceResult<GetCategoryByIdDto>.Failure(CategoryConstant.NotFound);
        }

        var categoryDto = mapper.Map<GetCategoryByIdDto>(category);

        return ServiceResult<GetCategoryByIdDto>.Success(categoryDto);
    }

    public async Task<ServiceResult<List<GetAllCategoriesDto>>> GetAllAsync()
    {
        var categoryDto = mapper.Map<List<GetAllCategoriesDto>>(await categoryRepository.GetAllAsync());
        return ServiceResult<List<GetAllCategoriesDto>>.Success(categoryDto);
    }

    public async Task<ServiceResult<int>> GetCountAsync(Expression<Func<Category,bool>> predicate = null)
    {
        if (predicate is null)
        {
            return ServiceResult<int>.Success(await categoryRepository.GetCountAsync());
        }
        return ServiceResult<int>.Success(await categoryRepository.GetCountAsync(predicate));
    }

    public async Task<ServiceResult> AddAsync(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        var category = mapper.Map<Category>(request);
        await categoryRepository.AddAsync(category);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateCategoryCommandRequest request,
        CancellationToken cancellationToken)
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

    public async Task<ServiceResult> DeleteAsync(DeleteCategoryCommandRequest request,
        CancellationToken cancellationToken)
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