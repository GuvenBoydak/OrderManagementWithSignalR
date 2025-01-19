namespace SignalRApp.Application.Features.Message.Queries.GetMessageById;

public record GetMessageByIdQueryRequest(int Id):IQuery<GetMessageByIdQueryResponse>;