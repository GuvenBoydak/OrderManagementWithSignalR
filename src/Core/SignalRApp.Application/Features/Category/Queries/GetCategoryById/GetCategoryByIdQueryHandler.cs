using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Category.Queries.GetCategoryById;

public record GetCategoryByIdQueryHandler(ICategoryService CategoryService):IQueryHandler<GetCategoryByIdQueryRequest,GetCategoryByIdQueryResponse>
{
    public async Task<GetCategoryByIdQueryResponse> Handle(GetCategoryByIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await CategoryService.GetByIdAsync(request.Id));
    }
}