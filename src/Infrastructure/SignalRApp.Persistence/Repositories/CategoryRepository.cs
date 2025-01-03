using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class CategoryRepository(OrderManagementDbContext context)
    : GenericRepository<Category>(context), ICategoryRepository;