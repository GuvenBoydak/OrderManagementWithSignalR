namespace SignalRApp.Application.Features.Product.Commands.Update;

public record UpdateProductCommandRequest(int Id,
    string Name,
    string Description,
    decimal Price,
    string ImageUrl,
    bool Status,
    int CategoryId):ICommand<UpdateProductCommandResponse>;