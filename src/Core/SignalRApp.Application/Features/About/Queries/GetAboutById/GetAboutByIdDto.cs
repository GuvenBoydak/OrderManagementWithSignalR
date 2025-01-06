namespace SignalRApp.Application.Features.About.Queries.GetAboutById;

public record GetAboutByIdDto(int Id,
    string Title,
    string Description,
    string ImageUrl);