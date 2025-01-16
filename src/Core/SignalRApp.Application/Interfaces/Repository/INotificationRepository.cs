using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Repository;

public interface INotificationRepository : IRepository<Notification>
{
    Task<List<Notification>> GetNotificationByIsReadAsync(bool isRead);
}