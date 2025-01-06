namespace SignalRApp.Application.Features.Contact.Queries.GetContactById;

public record GetContactByIdQueryRequest(int Id):IQuery<GetContactByIdQueryResponse>;