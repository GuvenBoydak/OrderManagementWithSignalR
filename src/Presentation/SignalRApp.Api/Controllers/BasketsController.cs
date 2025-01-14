using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Basket.Commands.Create;
using SignalRApp.Application.Features.Basket.Commands.Delete;
using SignalRApp.Application.Features.Basket.Commands.Update;
using SignalRApp.Application.Features.Basket.Queries.GetAllBaskets;
using SignalRApp.Application.Features.Basket.Queries.GetBasketById;
using SignalRApp.Application.Features.Basket.Queries.GetBasketByMenuTableId;

namespace SignalRApp.Api.Controllers;

public class BasketsController(IMediator mediator) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await mediator.Send(new GetAllBasketQueryRequest());
        return CreateActionResult(response.Result);
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] GetBasketByIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
    [HttpGet("{GetBasketByMenuTableId}")]
    public async Task<IActionResult> GetBasketByMenuTableId([FromRoute] GetBasketByMenuTableIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateBasketCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBasketCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteBasketCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}