using AutoMapper;
using SignalRApp.MvcUI.Models.Request.Notification;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.Mapping;

public class NotificationMappingProfile:Profile
{
    public NotificationMappingProfile()
    {
        CreateMap<NotificationResponse, UpdateNotificationRequest>().ReverseMap();
    }
}