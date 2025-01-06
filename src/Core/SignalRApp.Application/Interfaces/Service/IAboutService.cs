using SignalRApp.Application.Features.About.Commands.Create;
using SignalRApp.Application.Features.About.Commands.Delete;
using SignalRApp.Application.Features.About.Commands.Update;
using SignalRApp.Application.Features.About.Queries.GetAboutById;
using SignalRApp.Application.Features.About.Queries.GetAllAbout;
using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IAboutService
{
    Task<ServiceResult<GetAboutByIdDto>> GetByIdAsync(int id);
    Task<ServiceResult<List<GetAllAboutDto>>> GetAllAsync();
    Task<ServiceResult> AddAsync(CreateAboutCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateAboutCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteAboutCommandRequest request, CancellationToken cancellationToken);
}