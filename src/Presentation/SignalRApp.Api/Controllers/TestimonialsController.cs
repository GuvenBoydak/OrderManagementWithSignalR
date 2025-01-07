using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Testimonial.Commands.Create;
using SignalRApp.Application.Features.Testimonial.Commands.Delete;
using SignalRApp.Application.Features.Testimonial.Commands.Update;
using SignalRApp.Application.Features.Testimonial.Queries.GetAllTestimonial;
using SignalRApp.Application.Features.Testimonial.Queries.GetTestimonialById;

namespace SignalRApp.Api.Controllers;

public class TestimonialsController(IMediator mediator) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await mediator.Send(new GetAllTestimonialQueryRequest());
        return CreateActionResult(response.Result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] GetTestimonialByIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateTestimonialCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateTestimonialCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteTestimonialCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}