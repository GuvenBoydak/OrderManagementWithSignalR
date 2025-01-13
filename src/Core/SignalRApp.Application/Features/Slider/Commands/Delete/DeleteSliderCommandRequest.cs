namespace SignalRApp.Application.Features.Slider.Commands.Delete;

public record DeleteSliderCommandRequest(int Id):ICommand<DeleteSliderCommandResponse>;