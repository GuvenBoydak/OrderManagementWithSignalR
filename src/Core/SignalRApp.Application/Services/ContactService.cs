using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Contact.Commands.Create;
using SignalRApp.Application.Features.Contact.Commands.Delete;
using SignalRApp.Application.Features.Contact.Commands.Update;
using SignalRApp.Application.Features.Contact.Queries.GetAllContact;
using SignalRApp.Application.Features.Contact.Queries.GetContactById;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class ContactService(IContactRepository contactRepository, IUnitOfWork unitOfWork, IMapper mapper)
    : IContactService
{
    public async Task<ServiceResult<GetContactByIdDto>> GetByIdAsync(int id)
    {
        var contact = await contactRepository.GetByIdAsync(id);
        if (contact is null)
        {
            return ServiceResult<GetContactByIdDto>.Failure(ContactConstant.NotFound);
        }

        var contactDto = mapper.Map<GetContactByIdDto>(contact);
        return ServiceResult<GetContactByIdDto>.Success(contactDto);
    }

    public async Task<ServiceResult<List<GetAllContactDto>>> GetAllAsync()
    {
        var contacts = await contactRepository.GetAllAsync();
        return ServiceResult<List<GetAllContactDto>>.Success(mapper.Map<List<GetAllContactDto>>(contacts));
    }

    public async Task<ServiceResult> AddAsync(CreateContactCommandRequest request, CancellationToken cancellationToken)
    {
        var contact = mapper.Map<Contact>(request);
        await contactRepository.AddAsync(contact);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateContactCommandRequest request,
        CancellationToken cancellationToken)
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

    public async Task<ServiceResult> DeleteAsync(DeleteContactCommandRequest request,
        CancellationToken cancellationToken)
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