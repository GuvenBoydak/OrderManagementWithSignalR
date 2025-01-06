namespace SignalRApp.Application.Features.Contact.Commands.Update;

public record UpdateContactCommandRequest(int Id,
    string Location,
    string Phone,
    string Email,
    string FooterDescription)
    : ICommand<UpdateContactCommandResponse>;