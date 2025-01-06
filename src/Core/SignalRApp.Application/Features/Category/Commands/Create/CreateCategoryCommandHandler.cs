using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Category.Commands.Create;

public class CreateCategoryCommandHandler(ICategoryService categoryService):ICommandHandler<CreateCategoryCommandRequest,CreateCategoryCommandResponse>
{
    public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await categoryService.AddAsync(request,cancellationToken));
    }
}