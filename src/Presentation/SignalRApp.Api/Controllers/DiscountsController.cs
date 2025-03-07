using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Discount.Commands.Create;
using SignalRApp.Application.Features.Discount.Commands.Delete;
using SignalRApp.Application.Features.Discount.Commands.Update;
using SignalRApp.Application.Features.Discount.Queries.GetAllDiscount;
using SignalRApp.Application.Features.Discount.Queries.GetDiscountById;

namespace SignalRApp.Api.Controllers;

public class DiscountsController(IMediator mediator) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await mediator.Send(new GetAllDiscountQueryRequest());
        return CreateActionResult(response.Result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] GetDiscountByIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

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
    public async Task<IActionResult> Delete([FromRoute] DeleteDiscountCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}