using AutoMapper;
using SignalRApp.Application.Features.Notification.Commands.Create;
using SignalRApp.Application.Features.Notification.Commands.Update;
using SignalRApp.Application.Features.Notification.Queries.GetAllNotifications;
using SignalRApp.Application.Features.Notification.Queries.GetNotificationById;
using SignalRApp.Application.Features.Notification.Queries.GetNotificationsByIsRead;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class NotificationMapping:Profile
{
    public NotificationMapping()
    {
        CreateMap<Notification, CreateNotificationCommandRequest>().ReverseMap();
        CreateMap<Notification, UpdateNotificationCommandRequest>().ReverseMap();
        CreateMap<Notification, GetAllNotificationsDto>().ReverseMap();
        CreateMap<Notification, GetNotificationByIdDto>().ReverseMap();
        CreateMap<Notification, GetNotificationsByIsReadDto>().ReverseMap();
    }
}