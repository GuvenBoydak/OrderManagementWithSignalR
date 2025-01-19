using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Message.Queries.GetAllMessages;

public record GetAllMessagesQueryResponse(ServiceResult<List<GetAllMessagesDto>> Result);