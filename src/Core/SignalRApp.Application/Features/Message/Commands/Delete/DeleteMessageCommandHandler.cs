using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Message.Commands.Delete;

public class DeleteMessageCommandHandler(IMessageService messageService):ICommandHandler<DeleteMessageCommandRequest,DeleteMessageCommandResponse>
{
    public async Task<DeleteMessageCommandResponse> Handle(DeleteMessageCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await messageService.DeleteAsync(request,cancellationToken));
    }
}