using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Message.Commands.Create;
using SignalRApp.Application.Features.Message.Commands.Delete;
using SignalRApp.Application.Features.Message.Queries.GetAllMessages;
using SignalRApp.Application.Features.Message.Queries.GetMessageById;

namespace SignalRApp.Api.Controllers;

public class MessagesController(IMediator mediator) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await mediator.Send(new GetAllMessagesQueryRequest());
        return CreateActionResult(response.Result);
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] GetMessageByIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateMessageCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
    
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteMessageCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}