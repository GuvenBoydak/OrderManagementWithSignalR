using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Order.Commands.Create;
using SignalRApp.Application.Features.Order.Commands.Delete;
using SignalRApp.Application.Features.Order.Commands.Update;
using SignalRApp.Application.Features.Order.Queries.GetAllOrders;
using SignalRApp.Application.Features.Order.Queries.GetOrderById;

namespace SignalRApp.Api.Controllers;

public class OrderController(IMediator mediator):BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await mediator.Send(new GetAllOrdersQueryRequest());
        return CreateActionResult(response.Result);
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] GetOrderByIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateOrderCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteOrderCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}