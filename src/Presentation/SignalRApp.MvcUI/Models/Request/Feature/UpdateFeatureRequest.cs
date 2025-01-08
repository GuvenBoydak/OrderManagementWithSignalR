namespace SignalRApp.MvcUI.Models.Request.Feature;

public record UpdateFeatureRequest(int Id,string Title,string Description,string ImageUrl);