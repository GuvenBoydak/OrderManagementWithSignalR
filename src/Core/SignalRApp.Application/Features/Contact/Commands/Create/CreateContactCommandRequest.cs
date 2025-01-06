namespace SignalRApp.Application.Features.Contact.Commands.Create;

public record CreateContactCommandRequest(string Location,string Phone,string Email,string FooterDescription):ICommand<CreateContactCommandResponse>;