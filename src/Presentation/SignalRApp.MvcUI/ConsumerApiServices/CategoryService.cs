using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request;
using SignalRApp.MvcUI.Models.Request.Category;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class CategoryService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<CategoryResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<CategoryResponse>>>("categories");
        return result;
    }

    public async Task<ServiceResult<CategoryResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<CategoryResponse>>($"categories/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateCategoryRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("categories",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> UpdateAsync(UpdateCategoryRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("categories",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"categories/{id}");
        return result.IsSuccessStatusCode;
    }
}