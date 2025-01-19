using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.AppUser.Commands.RegiserAppUser;

public class RegisterAppUserCommandHandler(IAuthService authService):ICommandHandler<RegisterAppUserCommandRequest,RegisterAppUserCommandResponse>
{
    public async Task<RegisterAppUserCommandResponse> Handle(RegisterAppUserCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await authService.RegisterAsync(request));
    }
}