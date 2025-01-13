namespace SignalRApp.Application.Features.Slider.Commands.Update;

public record UpdateSliderCommandRequest(int Id,string Title,string Description):ICommand<UpdateSliderCommandResponse>;