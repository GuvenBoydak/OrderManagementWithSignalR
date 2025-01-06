using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Product.Commands.Create;

public class CreateProductCommandHandler(IProductService productService):ICommandHandler<CreateProductCommandRequest,CreateProductCommandResponse>
{
    public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await productService.AddAsync(request,cancellationToken));
    }
}