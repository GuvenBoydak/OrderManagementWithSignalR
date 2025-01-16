using Microsoft.EntityFrameworkCore;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class NotificationRepository(OrderManagementDbContext context) : GenericRepository<Notification>(context), INotificationRepository
{
    public Task<List<Notification>> GetNotificationByIsReadAsync(bool isRead)
    {
        return context.Notifications.Where(x => x.IsRead == false && x.IsDeleted == false).ToListAsync();
    }
}