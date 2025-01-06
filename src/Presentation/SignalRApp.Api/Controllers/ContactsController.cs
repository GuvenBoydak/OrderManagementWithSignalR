using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Contact.Commands.Create;
using SignalRApp.Application.Features.Contact.Commands.Delete;
using SignalRApp.Application.Features.Contact.Commands.Update;
using SignalRApp.Application.Features.Contact.Queries.GetAllContact;
using SignalRApp.Application.Features.Contact.Queries.GetContactById;

namespace SignalRApp.Api.Controllers;

public class ContactsController(IMediator mediator) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await mediator.Send(new GetAllContactQueryRequest());
        return CreateActionResult(response.Result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] GetContactByIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateContactCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateContactCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromBody] DeleteContactCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}