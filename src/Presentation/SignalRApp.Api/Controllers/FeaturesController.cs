using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Feature.Commands.Create;
using SignalRApp.Application.Features.Feature.Commands.Delete;
using SignalRApp.Application.Features.Feature.Commands.Update;

namespace SignalRApp.Api.Controllers;

public class FeaturesController(IMediator mediator):BaseController
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateFeatureCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateFeatureCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromBody] DeleteFeatureCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    } 
}