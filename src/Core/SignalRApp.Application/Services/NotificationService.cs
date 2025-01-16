using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Notification.Commands.Create;
using SignalRApp.Application.Features.Notification.Commands.Delete;
using SignalRApp.Application.Features.Notification.Commands.Update;
using SignalRApp.Application.Features.Notification.Queries.GetAllNotifications;
using SignalRApp.Application.Features.Notification.Queries.GetNotificationById;
using SignalRApp.Application.Features.Notification.Queries.GetNotificationsByIsRead;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class NotificationService(INotificationRepository notificationRepository,IUnitOfWork unitOfWork,IMapper mapper):INotificationService
{
    public async Task<ServiceResult<List<GetAllNotificationsDto>>> GetAllAsync()
    {
        var notifications = await notificationRepository.GetAllAsync();
        return ServiceResult<List<GetAllNotificationsDto>>.Success(
            mapper.Map<List<GetAllNotificationsDto>>(notifications));
    }

    public async Task<ServiceResult<GetNotificationByIdDto>> GetByIdAsync(int id)
    {
        var notification = await notificationRepository.GetByIdAsync(id);
        if (notification is null)
        {
            return ServiceResult<GetNotificationByIdDto>.Failure(NotificationConstant.NotFound);
        }

        var notificationDto = mapper.Map<GetNotificationByIdDto>(notification);
        return ServiceResult<GetNotificationByIdDto>.Success(notificationDto);
    }

    public async Task<ServiceResult<int>> GetNotificationCountByIsReadAsync(bool isRead)
    {
        return ServiceResult<int>
            .Success(await notificationRepository.GetCountAsync(x => x.IsRead == isRead));
    }

    public async Task<ServiceResult<List<GetNotificationsByIsReadDto>>> GetNotificationsByIsReadAsync(bool isRead)
    {
        var notifications = await notificationRepository.GetNotificationByIsReadAsync(isRead);
        return ServiceResult<List<GetNotificationsByIsReadDto>>.Success(
            mapper.Map<List<GetNotificationsByIsReadDto>>(notifications));
    }

    public async Task<ServiceResult> AddAsync(CreateNotificationCommandRequest request, CancellationToken cancellationToken)
    {
        var notification = mapper.Map<Notification>(request);
        
        await notificationRepository.AddAsync(notification);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> DeleteAsync(DeleteNotificationCommandRequest request, CancellationToken cancellationToken)
    {
        var notification = await notificationRepository.GetByIdAsync(request.Id);
        if (notification is null)
        {
            return ServiceResult.Failure(NotificationConstant.NotFound);
        }
        notificationRepository.Delete(notification);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateNotificationCommandRequest request, CancellationToken cancellationToken)
    {
        var notification = await notificationRepository.GetByIdAsync(request.Id);
        if (notification is null)
        {
            return ServiceResult.Failure(NotificationConstant.NotFound);
        }

        var updatedNotification = mapper.Map(request, notification);
        notificationRepository.Update(updatedNotification);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}