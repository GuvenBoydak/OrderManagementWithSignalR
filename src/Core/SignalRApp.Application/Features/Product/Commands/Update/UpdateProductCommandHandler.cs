using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Product.Commands.Update;

public class UpdateProductCommandHandler(IProductService productService):ICommandHandler<UpdateProductCommandRequest,UpdateProductCommandResponse>
{
    public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await productService.UpdateAsync(request,cancellationToken));
    }
}