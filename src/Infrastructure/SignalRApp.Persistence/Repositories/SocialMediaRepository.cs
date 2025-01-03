using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class SocialMediaRepository(OrderManagementDbContext context)
    : GenericRepository<SocialMedia>(context), ISocialMediaRepository;