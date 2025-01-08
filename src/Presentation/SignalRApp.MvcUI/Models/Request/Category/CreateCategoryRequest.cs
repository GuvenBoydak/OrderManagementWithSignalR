namespace SignalRApp.MvcUI.Models.Request.Category;

public record CreateCategoryRequest(string Name,bool Status = true);