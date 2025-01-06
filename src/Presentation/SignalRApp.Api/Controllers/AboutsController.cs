using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.About.Commands.Create;
using SignalRApp.Application.Features.About.Commands.Delete;
using SignalRApp.Application.Features.About.Commands.Update;
using SignalRApp.Application.Features.About.Queries.GetAboutById;
using SignalRApp.Application.Features.About.Queries.GetAllAbout;

namespace SignalRApp.Api.Controllers;

public class AboutsController(IMediator mediator) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await mediator.Send(new GetAllAboutQueryRequest());
        return CreateActionResult(response.Result);
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] GetAboutByIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateAboutCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateAboutCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteAboutCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}