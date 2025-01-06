namespace SignalRApp.Application.Features.Feature.Commands.Create;

public record CreateFeatureCommandRequest(string Title,string Description, string ImageUrl):ICommand<CreateFeatureCommandResponse>;