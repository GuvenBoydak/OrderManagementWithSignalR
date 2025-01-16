namespace SignalRApp.Application.Features.Notification.Commands.Update;

public record UpdateNotificationCommandRequest(int Id,string Description,string Type,string ImageUrl,bool IsRead):ICommand<UpdateNotificationCommandResponse>;