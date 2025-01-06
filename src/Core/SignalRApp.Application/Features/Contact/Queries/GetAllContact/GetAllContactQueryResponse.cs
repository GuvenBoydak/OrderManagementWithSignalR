using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Contact.Queries.GetAllContact;

public record GetAllContactQueryResponse(ServiceResult<List<GetAllContactDto>> Result);