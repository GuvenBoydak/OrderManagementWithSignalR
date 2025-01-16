using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Notification.Commands.Update;

public class UpdateNotificationCommandHandler(INotificationService notificationService):ICommandHandler<UpdateNotificationCommandRequest,UpdateNotificationCommandResponse>
{
    public async Task<UpdateNotificationCommandResponse> Handle(UpdateNotificationCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await notificationService.UpdateAsync(request,cancellationToken));
    }
}