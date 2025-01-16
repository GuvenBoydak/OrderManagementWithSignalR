using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request.Notification;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class NotificationService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<NotificationResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<NotificationResponse>>>("notifications");
        return result;
    }

    public async Task<ServiceResult<NotificationResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<NotificationResponse>>($"notifications/{id}");
        return result;
    }

    public async Task<ServiceResult<int>> GetNotificationCountByIsReadAsync(bool isRead)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<int>>
            ($"notifications/GetNotificationCountByIsRead/{isRead}");
        return result;
    }

    public async Task<ServiceResult<List<NotificationResponse>>> GetNotificationsByIsReadAsync(bool isRead)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<NotificationResponse>>>
            ($"notifications/GetNotificationsByIsRead/{isRead}");
        return result;
    }

    public async Task<bool> AddAsync(CreateNotificationRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("notifications", request);
        return result.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateAsync(UpdateNotificationRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("notifications", request);
        return result.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"notifications/{id}");
        return result.IsSuccessStatusCode;
    }
}