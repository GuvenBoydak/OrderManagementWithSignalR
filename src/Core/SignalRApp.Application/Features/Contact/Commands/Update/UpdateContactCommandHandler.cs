using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Contact.Commands.Update;

public class UpdateContactCommandHandler(IContactService contactService):ICommandHandler<UpdateContactCommandRequest,UpdateContactCommandResponse>
{
    public async Task<UpdateContactCommandResponse> Handle(UpdateContactCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await contactService.UpdateAsync(request,cancellationToken));
    }
}