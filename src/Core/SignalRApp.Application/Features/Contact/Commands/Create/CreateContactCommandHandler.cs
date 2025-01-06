using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Contact.Commands.Create;

public class CreateContactCommandHandler(IContactService contactService):ICommandHandler<CreateContactCommandRequest,CreateContactCommandResponse>
{
    public async Task<CreateContactCommandResponse> Handle(CreateContactCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await contactService.AddAsync(request,cancellationToken));
    }
}