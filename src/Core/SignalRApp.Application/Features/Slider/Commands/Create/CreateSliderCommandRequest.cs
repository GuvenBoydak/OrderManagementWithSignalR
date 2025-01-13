namespace SignalRApp.Application.Features.Slider.Commands.Create;

public record CreateSliderCommandRequest(string Title,string Description):ICommand<CreateSliderCommandResponse>;