using SignalRApp.MvcUI.Models;
using SignalRApp.MvcUI.Models.Request;
using SignalRApp.MvcUI.Models.Request.Contact;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class ContactService(HttpClient httpClient)
{
    public async Task<ServiceResult<List<ContactResponse>>> GetAllAsync()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<List<ContactResponse>>>("contacts");
        return result;
    }

    public async Task<ServiceResult<ContactResponse>> GetByIdAsync(int id)
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResult<ContactResponse>>($"contacts/{id}");
        return result;
    }

    public async Task<bool> AddAsync(CreateContactRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("contacts", request);
        return result.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateAsync(UpdateContactRequest request)
    {
        var result = await httpClient.PutAsJsonAsync("contacts", request);
        return result.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var result = await httpClient.DeleteAsync($"contacts/{id}");
        return result.IsSuccessStatusCode;
    }
}