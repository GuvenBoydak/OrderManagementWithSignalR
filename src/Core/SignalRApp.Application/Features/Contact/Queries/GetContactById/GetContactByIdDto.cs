namespace SignalRApp.Application.Features.Contact.Queries.GetContactById;

public record GetContactByIdDto(int Id,
    string Location,
    string Phone,
    string Email,
    string FooterDescription);