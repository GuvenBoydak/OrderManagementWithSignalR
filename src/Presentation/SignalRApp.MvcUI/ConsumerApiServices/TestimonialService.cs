using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request.Testimonial;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class TestimonialService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<TestimonialResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<TestimonialResponse>>>("testimonial");
        return result;
    }

    public async Task<ServiceResult<TestimonialResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<TestimonialResponse>>($"testimonial/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateTestimonialRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("testimonial", request);
        return result.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateAsync(UpdateTestimonialRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("testimonial", request);
        return result.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"testimonial/{id}");
        return result.IsSuccessStatusCode;
    }
}