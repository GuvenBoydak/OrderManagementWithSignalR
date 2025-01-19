namespace SignalRApp.MvcUI.Models.Request.AppUser;

public record CreateAppUserRequest(string Name,string Surname,string UserName,string Email,string Password);