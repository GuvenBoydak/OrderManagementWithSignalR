namespace SignalRApp.Application.Features.Feature.Commands.Delete;

public record DeleteFeatureCommandRequest(int Id):ICommand<DeleteFeatureCommandResponse>;