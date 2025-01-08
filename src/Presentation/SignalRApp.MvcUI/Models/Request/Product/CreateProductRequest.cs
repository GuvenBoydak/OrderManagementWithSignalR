namespace SignalRApp.MvcUI.Models.Request.Product;

public record CreateProductRequest(string Name,string Description,decimal Price,string ImageUrl,int CategoryId,bool Status = true);