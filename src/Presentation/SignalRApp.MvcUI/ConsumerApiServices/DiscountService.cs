using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request;
using SignalRApp.MvcUI.Models.Request.Discount;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class DiscountService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<DiscountResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<DiscountResponse>>>("discounts");
        return result;
    }

    public async Task<ServiceResult<DiscountResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<DiscountResponse>>($"discounts/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateDiscountRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("discounts", request);
        return result.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateAsync(UpdateDiscountRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("discounts", request);
        return result.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"discounts/{id}");
        return result.IsSuccessStatusCode;
    }
}