using SignalRApp.Application.Features.Message.Commands.Create;
using SignalRApp.Application.Features.Message.Commands.Delete;
using SignalRApp.Application.Features.Message.Queries.GetAllMessages;
using SignalRApp.Application.Features.Message.Queries.GetMessageById;
using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Interfaces.Service;

public interface IMessageService
{
    Task<ServiceResult<GetMessageByIdDto>> GetByIdAsync(int id);
    Task<ServiceResult<List<GetAllMessagesDto>>> GetAllAsync();
    Task<ServiceResult> AddAsync(CreateMessageCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteMessageCommandRequest request, CancellationToken cancellationToken);
}