using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.AppUser.Commands.LoginAppUser;

public record LoginAppUserCommandResponse(ServiceResult<bool> Result);