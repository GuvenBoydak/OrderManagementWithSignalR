using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Booking.Commands.Create;
using SignalRApp.Application.Features.Booking.Commands.Delete;
using SignalRApp.Application.Features.Booking.Commands.Update;
using SignalRApp.Application.Features.Booking.Queries.GetAllBookings;
using SignalRApp.Application.Features.Booking.Queries.GetBookingById;

namespace SignalRApp.Api.Controllers;

public class BookingsController(IMediator mediator):BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await mediator.Send(new GetAllBookingsQueryRequest());
        return CreateActionResult(response.Result);
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] GetBookingByIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
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
    public async Task<IActionResult> Delete([FromRoute] DeleteBookingCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}