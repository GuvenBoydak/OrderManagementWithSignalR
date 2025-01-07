using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request;
using SignalRApp.MvcUI.Models.Request.About;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class AboutService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<AboutResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<AboutResponse>>>("abouts");
        return result;
    }

    public async Task<ServiceResult<AboutResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<AboutResponse>>($"abouts/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateAboutRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("abouts",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> UpdateAsync(UpdateAboutRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("abouts",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"abouts/{id}");
        return result.IsSuccessStatusCode;
    }
}