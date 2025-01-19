namespace SignalRApp.Application.Features.AppUser.Commands.RegiserAppUser;

public record RegisterAppUserCommandRequest(string Name,string Surname,string UserName,string Email,string Password):ICommand<RegisterAppUserCommandResponse>;