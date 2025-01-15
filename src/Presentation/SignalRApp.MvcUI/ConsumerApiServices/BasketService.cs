using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request.Basket;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class BasketService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<BasketResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<BasketResponse>>>("baskets");
        return result;
    }

    public async Task<ServiceResult<BasketResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<BasketResponse>>($"baskets/{id}");
        return result;
    }
    public async Task<ServiceResult<List<BasketResponse>>> GetBasketByMenuTableIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<BasketResponse>>>($"baskets/GetBasketByMenuTableId/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateBasketRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("baskets",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> UpdateAsync(UpdateBasketRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("baskets",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"baskets/{id}");
        return result.IsSuccessStatusCode;
    }
}