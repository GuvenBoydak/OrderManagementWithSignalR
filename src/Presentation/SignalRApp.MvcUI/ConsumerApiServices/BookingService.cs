using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request;
using SignalRApp.MvcUI.Models.Request.Booking;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class BookingService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<BookingResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<BookingResponse>>>("bookings");
        return result;
    }

    public async Task<ServiceResult<BookingResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<BookingResponse>>($"bookings/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateBookingRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("bookings",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> UpdateAsync(UpdateBookingRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("bookings",request);
        return result.IsSuccessStatusCode;
    }
    
    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"bookings/{id}");
        return result.IsSuccessStatusCode;
    }
}