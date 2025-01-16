using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Notification.Commands.Create;

public class CreateNotificationCommandHandler(INotificationService notificationService):ICommandHandler<CreateNotificationCommandRequest,CreateNotificationCommandResponse>
{
    public async Task<CreateNotificationCommandResponse> Handle(CreateNotificationCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await notificationService.AddAsync(request,cancellationToken));
    }
}