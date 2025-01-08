namespace SignalRApp.MvcUI.Models.Request.Product;

public record UpdateProductRequest(int Id,string Name,string Description,decimal Price,string ImageUrl,int CategoryId,bool Status = true);