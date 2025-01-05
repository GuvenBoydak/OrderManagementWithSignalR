using SignalRApp.Application.Features.Contact.Commands.Create;
using SignalRApp.Application.Features.Contact.Commands.Delete;
using SignalRApp.Application.Features.Contact.Commands.Update;
using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IContactService
{
    Task<Contact> GetByIdAsync(int id);
    Task<List<Contact>> GetAllAsync();
    Task<ServiceResult> AddAsync(CreateContactCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateContactCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteContactCommandRequest request,CancellationToken cancellationToken);
}