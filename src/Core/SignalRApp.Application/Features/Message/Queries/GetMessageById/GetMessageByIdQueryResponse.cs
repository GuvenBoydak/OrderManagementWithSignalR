using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Message.Queries.GetMessageById;

public record GetMessageByIdQueryResponse(ServiceResult<GetMessageByIdDto> Result);