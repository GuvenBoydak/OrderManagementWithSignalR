using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request.Order;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class OrderService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<OrderResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<OrderResponse>>>("orders");
        return result;
    }

    public async Task<ServiceResult<OrderResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<OrderResponse>>($"orders/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateOrderRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("orders",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> UpdateAsync(UpdateOrderRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("orders",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"orders/{id}");
        return result.IsSuccessStatusCode;
    }
}