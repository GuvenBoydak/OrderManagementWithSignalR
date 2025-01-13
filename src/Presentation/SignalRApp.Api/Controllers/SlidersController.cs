using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.About.Commands.Create;
using SignalRApp.Application.Features.About.Commands.Delete;
using SignalRApp.Application.Features.About.Commands.Update;
using SignalRApp.Application.Features.About.Queries.GetAboutById;
using SignalRApp.Application.Features.About.Queries.GetAllAbout;
using SignalRApp.Application.Features.Slider.Commands.Create;
using SignalRApp.Application.Features.Slider.Commands.Delete;
using SignalRApp.Application.Features.Slider.Commands.Update;
using SignalRApp.Application.Features.Slider.Queries.GetAllSliders;
using SignalRApp.Application.Features.Slider.Queries.GetSliderById;

namespace SignalRApp.Api.Controllers;

public class SlidersController(IMediator mediator) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await mediator.Send(new GetAllSliderQueryRequest());
        return CreateActionResult(response.Result);
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] GetSliderByIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateSliderCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateSliderCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteSliderCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}