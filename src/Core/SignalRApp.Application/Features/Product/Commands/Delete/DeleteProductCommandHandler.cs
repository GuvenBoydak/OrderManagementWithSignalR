using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Product.Commands.Delete;

public class DeleteProductCommandHandler(IProductService productService):ICommandHandler<DeleteProductCommandRequest,DeleteProductCommandResponse>
{
    public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await productService.DeleteAsync(request,cancellationToken));
    }
}