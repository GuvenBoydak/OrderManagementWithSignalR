namespace SignalRApp.MvcUI.Models.Request.About;

public record UpdateAboutRequest(int Id,string Title, string Description, string ImageUrl);