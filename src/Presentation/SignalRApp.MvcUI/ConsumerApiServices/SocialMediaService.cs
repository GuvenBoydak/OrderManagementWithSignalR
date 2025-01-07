using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request;
using SignalRApp.MvcUI.Models.Request.SocialMedia;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class SocialMediaService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<SocialMediaResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<SocialMediaResponse>>>("socialmedias");
        return result;
    }

    public async Task<ServiceResult<SocialMediaResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<SocialMediaResponse>>($"socialmedias/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateSocialMediaRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("socialmedias",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> UpdateAsync(UpdateSocialMediaRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("socialmedias",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"socialmedias/{id}");
        return result.IsSuccessStatusCode;
    } 
}