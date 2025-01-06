using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Feature.Commands.Delete;

public class DeleteFeatureCommandHandler(IFeatureService featureService):ICommandHandler<DeleteFeatureCommandRequest,DeleteFeatureCommandResponse>
{
    public async Task<DeleteFeatureCommandResponse> Handle(DeleteFeatureCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await featureService.DeleteAsync(request,cancellationToken));
    }
}