using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.About.Commands.Update;

public class UpdateAboutCommandHandler(IAboutService aboutService)
    : ICommandHandler<UpdateAboutCommandRequest, UpdateAboutCommandResponse>
{
    public async Task<UpdateAboutCommandResponse> Handle(UpdateAboutCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await aboutService.UpdateAsync(request,cancellationToken));
    }
}