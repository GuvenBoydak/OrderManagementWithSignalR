using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Message.Commands.Create;
using SignalRApp.Application.Features.Message.Commands.Delete;
using SignalRApp.Application.Features.Message.Queries.GetAllMessages;
using SignalRApp.Application.Features.Message.Queries.GetMessageById;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class MessageService(IMessageRepository messageRepository,IUnitOfWork unitOfWork,IMapper mapper): IMessageService
{
    public async Task<ServiceResult<GetMessageByIdDto>> GetByIdAsync(int id)
    {
        var message = await messageRepository.GetByIdAsync(id);
        if (message is null)
        {
            return ServiceResult<GetMessageByIdDto>.Failure(MessageConstant.NotFound);
        }

        var messageDto = mapper.Map<GetMessageByIdDto>(message);
        return ServiceResult<GetMessageByIdDto>.Success(messageDto);
    }

    public async Task<ServiceResult<List<GetAllMessagesDto>>> GetAllAsync()
    {
        var messageDto =  mapper.Map<List<GetAllMessagesDto>>(await messageRepository.GetAllAsync());
        return ServiceResult<List<GetAllMessagesDto>>.Success(messageDto);
    }

    public async Task<ServiceResult> AddAsync(CreateMessageCommandRequest request,CancellationToken cancellationToken)
    {
        var message = mapper.Map<Message>(request);
        await messageRepository.AddAsync(message);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
    

    public async Task<ServiceResult> DeleteAsync(DeleteMessageCommandRequest request,CancellationToken cancellationToken)
    {
        var message = await messageRepository.GetByIdAsync(request.Id);
        if (message is null)
        {
            return ServiceResult.Failure(MessageConstant.NotFound);
        }
        
        messageRepository.Delete(message);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}