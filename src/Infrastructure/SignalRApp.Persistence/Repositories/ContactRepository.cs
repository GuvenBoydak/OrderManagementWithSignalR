using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class ContactRepository(OrderManagementDbContext context)
    : GenericRepository<Contact>(context), IContactRepository;