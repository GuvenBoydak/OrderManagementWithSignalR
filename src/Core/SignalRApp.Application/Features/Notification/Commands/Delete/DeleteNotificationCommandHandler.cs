using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Notification.Commands.Delete;

public class DeleteNotificationCommandHandler(INotificationService notificationService):ICommandHandler<DeleteNotificationCommandRequest,DeleteNotificationCommandResponse>
{
    public async Task<DeleteNotificationCommandResponse> Handle(DeleteNotificationCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await notificationService.DeleteAsync(request,cancellationToken));
    }
}