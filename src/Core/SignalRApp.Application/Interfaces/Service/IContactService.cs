using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IContactService
{
    Task<Contact> GetByIdAsync(int id);
    Task<List<Contact>> GetAllAsync();
    ValueTask AddAsync(Contact contact,CancellationToken cancellationToken);
    ValueTask UpdateAsync(Contact contact,CancellationToken cancellationToken);
    ValueTask DeleteAsync(Contact contact,CancellationToken cancellationToken);
}