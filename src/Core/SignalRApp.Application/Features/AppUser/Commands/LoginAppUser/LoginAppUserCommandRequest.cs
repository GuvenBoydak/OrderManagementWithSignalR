namespace SignalRApp.Application.Features.AppUser.Commands.LoginAppUser;

public record LoginAppUserCommandRequest(string UserName,string Password):ICommand<LoginAppUserCommandResponse>;