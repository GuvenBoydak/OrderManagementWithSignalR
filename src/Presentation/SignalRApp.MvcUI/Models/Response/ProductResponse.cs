namespace SignalRApp.MvcUI.Models.Response;

public record ProductResponse(int Id,string Name,string Description,decimal Price,string ImageUrl,bool Status,CategoryResponse Category);