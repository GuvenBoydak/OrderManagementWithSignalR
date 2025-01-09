namespace SignalRApp.Application.Features.Category.Commands.Update;

public record UpdateCategoryCommandRequest(int Id,string Name):ICommand<UpdateCategoryCommandResponse>;