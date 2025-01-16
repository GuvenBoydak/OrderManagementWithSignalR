using SignalRApp.Application.Features.Notification.Commands.Create;
using SignalRApp.Application.Features.Notification.Commands.Delete;
using SignalRApp.Application.Features.Notification.Commands.Update;
using SignalRApp.Application.Features.Notification.Queries.GetAllNotifications;
using SignalRApp.Application.Features.Notification.Queries.GetNotificationById;
using SignalRApp.Application.Features.Notification.Queries.GetNotificationsByIsRead;
using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Interfaces.Service;

public interface INotificationService
{
    Task<ServiceResult<List<GetAllNotificationsDto>>> GetAllAsync();
    Task<ServiceResult<GetNotificationByIdDto>> GetByIdAsync(int id);
    Task<ServiceResult<int>> GetNotificationCountByIsReadAsync(bool isRead);
    Task<ServiceResult<List<GetNotificationsByIsReadDto>>> GetNotificationsByIsReadAsync(bool isRead);
    Task<ServiceResult> AddAsync(CreateNotificationCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteNotificationCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateNotificationCommandRequest request, CancellationToken cancellationToken);
}