namespace SignalRApp.Application.Features.Category.Commands.Delete;

public record DeleteCategoryCommandRequest(int Id):ICommand<DeleteCategoryCommandResponse>;