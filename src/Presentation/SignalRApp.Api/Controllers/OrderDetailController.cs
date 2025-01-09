using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.OrderDetail.Commands.Create;
using SignalRApp.Application.Features.OrderDetail.Commands.Delete;
using SignalRApp.Application.Features.OrderDetail.Commands.Update;
using SignalRApp.Application.Features.OrderDetail.Queries.GetAllOrderDetails;
using SignalRApp.Application.Features.OrderDetail.Queries.GetOrderDetailById;

namespace SignalRApp.Api.Controllers;

public class OrderDetailController(IMediator mediator):BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await mediator.Send(new GetAllOrderDetailsQueryRequest());
        return CreateActionResult(response.Result);
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] GetOrderDetailByIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateOrderDetailCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderDetailCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteOrderDetailCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}