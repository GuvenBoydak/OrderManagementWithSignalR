using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request;
using SignalRApp.MvcUI.Models.Request.Feature;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class FeatureService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<FeatureResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<FeatureResponse>>>("features");
        return result;
    }

    public async Task<ServiceResult<FeatureResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<FeatureResponse>>($"features/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateFeatureRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("features", request);
        return result.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateAsync(UpdateFeatureRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("features", request);
        return result.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"features/{id}");
        return result.IsSuccessStatusCode;
    }
}