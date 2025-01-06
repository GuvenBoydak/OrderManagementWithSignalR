namespace SignalRApp.Application.Features.About.Queries.GetAllAbout;

public record GetAllAboutDto(int Id,
    string Title,
    string Description,
    string ImageUrl);