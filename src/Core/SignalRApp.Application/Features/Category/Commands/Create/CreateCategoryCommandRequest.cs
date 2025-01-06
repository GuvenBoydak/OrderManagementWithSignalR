namespace SignalRApp.Application.Features.Category.Commands.Create;

public record CreateCategoryCommandRequest(string Name,bool Status):ICommand<CreateCategoryCommandResponse>;