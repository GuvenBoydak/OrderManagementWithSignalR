namespace SignalRApp.Application.Features.Product.Commands.Delete;

public record DeleteProductCommandRequest(int Id):ICommand<DeleteProductCommandResponse>;