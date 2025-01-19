using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.AppUser.Commands.LoginAppUser;

public class LoginAppUserCommandHandler(IAuthService authService):ICommandHandler<LoginAppUserCommandRequest,LoginAppUserCommandResponse>
{
    public async Task<LoginAppUserCommandResponse> Handle(LoginAppUserCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await authService.LoginAsync(request));
    }
}