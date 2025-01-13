using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request.About;
using SignalRApp.MvcUI.Models.Request.Slider;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class SliderService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<SliderResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<SliderResponse>>>("sliders");
        return result;
    }

    public async Task<ServiceResult<SliderResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<SliderResponse>>($"sliders/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateSliderRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("sliders",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> UpdateAsync(UpdateSliderRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("sliders",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"sliders/{id}");
        return result.IsSuccessStatusCode;
    }
}