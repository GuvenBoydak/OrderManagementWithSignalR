namespace SignalRApp.MvcUI.Models.Request.Category;

public record UpdateCategoryRequest(int Id,string Name,bool Status = true);