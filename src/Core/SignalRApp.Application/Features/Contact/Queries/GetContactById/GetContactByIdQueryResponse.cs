using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Contact.Queries.GetContactById;

public record GetContactByIdQueryResponse(ServiceResult<GetContactByIdDto> Result);