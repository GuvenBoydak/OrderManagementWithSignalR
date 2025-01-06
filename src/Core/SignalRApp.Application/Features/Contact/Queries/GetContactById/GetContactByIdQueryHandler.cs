using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Contact.Queries.GetContactById;

public record GetContactByIdQueryHandler(IContactService contactService):IQueryHandler<GetContactByIdQueryRequest,GetContactByIdQueryResponse>
{
    public async Task<GetContactByIdQueryResponse> Handle(GetContactByIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await contactService.GetByIdAsync(request.Id));
    }
}