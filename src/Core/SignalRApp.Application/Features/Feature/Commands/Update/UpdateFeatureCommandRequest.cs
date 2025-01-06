namespace SignalRApp.Application.Features.Feature.Commands.Update;

public record UpdateFeatureCommandRequest(int Id,string Title,string Description, string ImageUrl):ICommand<UpdateFeatureCommandResponse>;