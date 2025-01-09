using System.Linq.Expressions;
using SignalRApp.Application.Features.Category.Commands.Create;
using SignalRApp.Application.Features.Category.Commands.Delete;
using SignalRApp.Application.Features.Category.Commands.Update;
using SignalRApp.Application.Features.Category.Queries.GetAllCategories;
using SignalRApp.Application.Features.Category.Queries.GetCategoryById;
using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface ICategoryService
{
    Task<ServiceResult<GetCategoryByIdDto>> GetByIdAsync(int id);
    Task<ServiceResult<List<GetAllCategoriesDto>>> GetAllAsync();
    Task<ServiceResult<int>> GetCountAsync(Expression<Func<Category,bool>> predicate = null);
    Task<ServiceResult> AddAsync(CreateCategoryCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateCategoryCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteCategoryCommandRequest request,CancellationToken cancellationToken);
}