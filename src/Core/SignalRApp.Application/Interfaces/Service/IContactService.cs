using SignalRApp.Application.Features.Contact.Commands.Create;
using SignalRApp.Application.Features.Contact.Commands.Delete;
using SignalRApp.Application.Features.Contact.Commands.Update;
using SignalRApp.Application.Features.Contact.Queries.GetAllContact;
using SignalRApp.Application.Features.Contact.Queries.GetContactById;
using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IContactService
{
    Task<ServiceResult<GetContactByIdDto>> GetByIdAsync(int id);
    Task<ServiceResult<List<GetAllContactDto>>> GetAllAsync();
    Task<ServiceResult> AddAsync(CreateContactCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateContactCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteContactCommandRequest request,CancellationToken cancellationToken);
}