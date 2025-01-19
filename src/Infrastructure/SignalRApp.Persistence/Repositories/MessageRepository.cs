using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class MessageRepository(OrderManagementDbContext context) : GenericRepository<Message>(context), IMessageRepository;