using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Message.Commands.Create;

public class CreateMessageCommandHandler(IMessageService messageService):ICommandHandler<CreateMessageCommandRequest,CreateMessageCommandResponse>
{
    public async Task<CreateMessageCommandResponse> Handle(CreateMessageCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await messageService.AddAsync(request, cancellationToken));
    }
}