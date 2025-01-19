using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request.About;
using SignalRApp.MvcUI.Models.Request.Message;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class MessageService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<MessageResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<MessageResponse>>>("messages");
        return result;
    }

    public async Task<ServiceResult<MessageResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<MessageResponse>>($"messages/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateMessageRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("messages",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"messages/{id}");
        return result.IsSuccessStatusCode;
    }
}