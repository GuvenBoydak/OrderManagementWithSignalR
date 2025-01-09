using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request.OrderDetail;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class OrderDetailService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<OrderDetailResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<OrderDetailResponse>>>("orderDetails");
        return result;
    }

    public async Task<ServiceResult<OrderDetailResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<OrderDetailResponse>>($"orderDetails/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateOrderDetailRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("orderDetails",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> UpdateAsync(UpdateOrderDetailRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("orderDetails",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"orderDetails/{id}");
        return result.IsSuccessStatusCode;
    }
}