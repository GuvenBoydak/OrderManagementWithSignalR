namespace SignalRApp.Application.Features.Product.Commands.Create;

public record CreateProductCommandRequest(string Name,
    string Description,
    decimal Price,
    string ImageUrl,
    bool Status,
    int CategoryId):ICommand<CreateProductCommandResponse>;