using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Order.Commands.Create;
using SignalRApp.Application.Features.Order.Commands.Delete;
using SignalRApp.Application.Features.Order.Commands.Update;
using SignalRApp.Application.Features.Order.Queries.GetAllOrders;
using SignalRApp.Application.Features.Order.Queries.GetOrderById;
using SignalRApp.Application.Features.Order.Queries.GetTodayTotalPrice;
using SignalRApp.Application.Features.Order.Queries.GetTotalOrder;
using SignalRApp.Application.Features.Order.Queries.GetTotalPriceOrder;

namespace SignalRApp.Api.Controllers;

public class OrderController(IMediator mediator) : BaseController
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

    [HttpGet("{GetTotalOrder}")]
    public async Task<IActionResult> GetTotalOrder()
    {
        var response = await mediator.Send(new GetTotalOrderQueryRequest());
        return CreateActionResult(response.Result);
    }
    
    [HttpGet("{GetTotalPrice}")]
    public async Task<IActionResult> GetTotalPrice()
    {
        var response = await mediator.Send(new GetTotalPriceOrderQueryRequest());
        return CreateActionResult(response.Result);
    }
    [HttpGet("{GetTodayTotalPrice}")]
    public async Task<IActionResult> GetTodayTotalPrice()
    {
        var response = await mediator.Send(new GetTodayTotalPriceQueryRequest());
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