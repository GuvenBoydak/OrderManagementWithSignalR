using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Contact.Commands.Create;
using SignalRApp.Application.Features.Contact.Commands.Delete;
using SignalRApp.Application.Features.Contact.Commands.Update;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class ContactService(IContactRepository contactRepository,IUnitOfWork unitOfWork,IMapper mapper): IContactService
{
    public async Task<Contact> GetByIdAsync(int id)
    {
        var contact = await contactRepository.GetByIdAsync(id);
        if (contact is null)
        {
            throw new Exception(ContactConstant.NotFound);
        }

        return contact;
    }

    public async Task<List<Contact>> GetAllAsync()
    {
        return await contactRepository.GetAllAsync();
    }

    public async Task<ServiceResult> AddAsync(CreateContactCommandRequest request, CancellationToken cancellationToken)
    {
        var contact = mapper.Map<Contact>(request);
        await contactRepository.AddAsync(contact);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateContactCommandRequest request, CancellationToken cancellationToken)
    {
        var contact = await contactRepository.GetByIdAsync(request.Id);
        if (contact is null)
        {
            return ServiceResult.Failure(ContactConstant.NotFound);
        }

        var updatedContact = mapper.Map(request, contact);
        contactRepository.Update(updatedContact);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> DeleteAsync(DeleteContactCommandRequest request, CancellationToken cancellationToken)
    {
        var contact = await contactRepository.GetByIdAsync(request.Id);
        if (contact is null)
        {
            return ServiceResult.Failure(ContactConstant.NotFound);
        }
        
        contactRepository.Delete(contact);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}