using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Category.Commands.Delete;

public class DeleteCategoryCommandHandler(ICategoryService categoryService):ICommandHandler<DeleteCategoryCommandRequest,DeleteCategoryCommandResponse>
{
    public async Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await categoryService.DeleteAsync(request,cancellationToken));
    }
}