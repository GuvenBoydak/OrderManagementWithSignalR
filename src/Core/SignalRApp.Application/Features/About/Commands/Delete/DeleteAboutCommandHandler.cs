using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.About.Commands.Delete;

public class DeleteAboutCommandHandler(IAboutService aboutService) : ICommandHandler<DeleteAboutCommandRequest, DeleteAboutCommandResponse>
{
    public async Task<DeleteAboutCommandResponse> Handle(DeleteAboutCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await aboutService.DeleteAsync(request,cancellationToken));
    }
}