using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Category.Commands.Update;

public class UpdateCategoryCommandHandler(ICategoryService categoryService):ICommandHandler<UpdateCategoryCommandRequest,UpdateCategoryCommandResponse>
{
    public async Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await categoryService.UpdateAsync(request,cancellationToken));
    }
}