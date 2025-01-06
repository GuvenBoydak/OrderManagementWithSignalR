using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Contact.Commands.Delete;

public class DeleteContactCommandHandler(IContactService contactService):ICommandHandler<DeleteContactCommandRequest,DeleteContactCommandResponse>
{
    public async Task<DeleteContactCommandResponse> Handle(DeleteContactCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await contactService.DeleteAsync(request,cancellationToken));
    }
}