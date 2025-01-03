using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.UnitOfWork;

public class UnitOfWork(OrderManagementDbContext context):IUnitOfWork
{
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return context.SaveChangesAsync(cancellationToken);
    }
}