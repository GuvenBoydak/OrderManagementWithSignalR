namespace SignalRApp.Application.Features.Contact.Queries.GetAllContact;

public record GetAllContactDto(int Id,
    string Location,
    string Phone,
    string Email,
    string FooterDescription);