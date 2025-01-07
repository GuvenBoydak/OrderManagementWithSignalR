using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request;
using SignalRApp.MvcUI.Models.Request.Product;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class ProductService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<ProductResponse>>> GetProductsWithCategoryAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<ProductResponse>>>("products/GetProductsWithCategory");
        return result;
    }

    public async Task<ServiceResult<ProductResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<ProductResponse>>($"products/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateProductRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("products",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> UpdateAsync(UpdateProductRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("products",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"products/{id}");
        return result.IsSuccessStatusCode;
    } 
}