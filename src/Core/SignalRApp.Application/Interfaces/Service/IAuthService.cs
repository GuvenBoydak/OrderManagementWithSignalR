using SignalRApp.Application.Features.AppUser.Commands.LoginAppUser;
using SignalRApp.Application.Features.AppUser.Commands.RegiserAppUser;
using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Interfaces.Service;

public interface IAuthService
{
    Task<ServiceResult> RegisterAsync(RegisterAppUserCommandRequest request);
    Task<ServiceResult<bool>> LoginAsync(LoginAppUserCommandRequest request);
}