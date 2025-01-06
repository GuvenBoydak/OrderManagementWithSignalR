using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.About.Commands.Create;

public class CreateAboutCommandHandler(IAboutService aboutService) : ICommandHandler<CreateAboutCommandRequest, CreateAboutCommandResponse>
{
    public async Task<CreateAboutCommandResponse> Handle(CreateAboutCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await aboutService.AddAsync(request,cancellationToken));
    }
}