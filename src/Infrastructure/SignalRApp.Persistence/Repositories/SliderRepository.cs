using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class SliderRepository(OrderManagementDbContext context) : GenericRepository<Slider>(context), ISliderRepository;