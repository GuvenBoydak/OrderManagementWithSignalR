using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.About.Commands.Create;
using SignalRApp.Application.Features.About.Commands.Delete;
using SignalRApp.Application.Features.About.Commands.Update;

namespace SignalRApp.Api.Controllers;

public class AboutsController(IMediator mediator) : BaseController
{
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
    public async Task<IActionResult> Delete([FromBody] DeleteAboutCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}