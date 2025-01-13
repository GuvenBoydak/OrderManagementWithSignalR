using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request.Testimonial;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class TestimonialService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<TestimonialResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<TestimonialResponse>>>("testimonials");
        return result;
    }

    public async Task<ServiceResult<TestimonialResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<TestimonialResponse>>($"testimonials/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateTestimonialRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("testimonials", request);
        return result.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateAsync(UpdateTestimonialRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("testimonials", request);
        return result.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"testimonials/{id}");
        return result.IsSuccessStatusCode;
    }
}