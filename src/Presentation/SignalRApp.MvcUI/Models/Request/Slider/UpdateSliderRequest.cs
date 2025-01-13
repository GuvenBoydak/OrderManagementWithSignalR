namespace SignalRApp.MvcUI.Models.Request.Slider;

public record UpdateSliderRequest(int Id,
    string Title,
    string Description);