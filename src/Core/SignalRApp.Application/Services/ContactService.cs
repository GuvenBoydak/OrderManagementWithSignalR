using SignalRApp.Application.Constants;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class ContactService(IContactRepository contactRepository,IUnitOfWork unitOfWork): IContactService
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

    public async ValueTask AddAsync(Contact contact, CancellationToken cancellationToken)
    {
        await contactRepository.AddAsync(contact);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask UpdateAsync(Contact contact, CancellationToken cancellationToken)
    {
        contactRepository.Update(contact);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async ValueTask DeleteAsync(Contact contact, CancellationToken cancellationToken)
    {
        contactRepository.Delete(contact);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}