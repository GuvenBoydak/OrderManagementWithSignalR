namespace SignalRApp.Application.Features.Notification.Commands.Create;

public record CreateNotificationCommandRequest(string Description,string Type,string ImageUrl,bool IsRead):ICommand<CreateNotificationCommandResponse>;