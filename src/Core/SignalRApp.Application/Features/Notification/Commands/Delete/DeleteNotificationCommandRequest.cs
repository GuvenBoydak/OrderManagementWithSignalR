namespace SignalRApp.Application.Features.Notification.Commands.Delete;

public record DeleteNotificationCommandRequest(int Id):ICommand<DeleteNotificationCommandResponse>;