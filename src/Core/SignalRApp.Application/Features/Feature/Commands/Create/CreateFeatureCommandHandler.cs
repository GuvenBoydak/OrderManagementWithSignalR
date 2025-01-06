using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Feature.Commands.Create;

public class CreateFeatureCommandHandler(IFeatureService featureService):ICommandHandler<CreateFeatureCommandRequest,CreateFeatureCommandResponse>
{
    public async Task<CreateFeatureCommandResponse> Handle(CreateFeatureCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await featureService.AddAsync(request,cancellationToken));
    }
}