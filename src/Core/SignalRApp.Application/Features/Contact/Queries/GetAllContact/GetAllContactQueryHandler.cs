using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Contact.Queries.GetAllContact;

public class GetAllContactQueryHandler(IContactService contactService):IQueryHandler<GetAllContactQueryRequest,GetAllContactQueryResponse>
{
    public async Task<GetAllContactQueryResponse> Handle(GetAllContactQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await contactService.GetAllAsync());
    }
}