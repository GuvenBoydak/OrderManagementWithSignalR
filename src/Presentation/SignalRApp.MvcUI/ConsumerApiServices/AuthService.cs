using SignalRApp.MvcUI.Models.Request.AppUser;

namespace SignalRApp.MvcUI.ConsumerApiServices;

public class AuthService(HttpClient httpClient)
{
    public async Task<bool> ReqisterAsync(CreateAppUserRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("auths/register",request);
        return result.IsSuccessStatusCode;
    }
    public async Task<bool> LoginAsync(LoginAppUserRequest request)
    {
        var result = await httpClient.PostAsJsonAsync("auths/login",request);
        return result.IsSuccessStatusCode;
    }
}