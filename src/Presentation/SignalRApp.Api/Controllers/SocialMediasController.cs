using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.SocialMedia.Commands.Create;
using SignalRApp.Application.Features.SocialMedia.Commands.Delete;
using SignalRApp.Application.Features.SocialMedia.Commands.Update;
using SignalRApp.Application.Features.SocialMedia.Queries.GetAllSocialMedia;
using SignalRApp.Application.Features.SocialMedia.Queries.GetSocialMediaById;

namespace SignalRApp.Api.Controllers;

public class SocialMediasController(IMediator mediator) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await mediator.Send(new GetAllSocialMediaQueryRequest());
        return CreateActionResult(response.Result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] GetSocialMediaByIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateSocialMediaCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateSocialMediaCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteSocialMediaCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}