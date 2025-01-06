using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Feature.Commands.Update;

public class UpdateFeatureCommandHandler(IFeatureService featureService):ICommandHandler<UpdateFeatureCommandRequest,UpdateFeatureCommandResponse>
{
    public async Task<UpdateFeatureCommandResponse> Handle(UpdateFeatureCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await featureService.UpdateAsync(request,cancellationToken));
    }
}