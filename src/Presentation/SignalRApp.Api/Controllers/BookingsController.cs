using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Booking.Commands.Create;
using SignalRApp.Application.Features.Booking.Commands.Delete;
using SignalRApp.Application.Features.Booking.Commands.Update;

namespace SignalRApp.Api.Controllers;

public class BookingsController(IMediator mediator):BaseController
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateBookingCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBookingCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromBody] DeleteBookingCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}