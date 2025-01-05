using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Discount.Commands.Create;
using SignalRApp.Application.Features.Discount.Commands.Delete;
using SignalRApp.Application.Features.Discount.Commands.Update;

namespace SignalRApp.Api.Controllers;

public class DiscountsController(IMediator mediator):BaseController
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateDiscountCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateDiscountCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromBody] DeleteDiscountCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    } 
}