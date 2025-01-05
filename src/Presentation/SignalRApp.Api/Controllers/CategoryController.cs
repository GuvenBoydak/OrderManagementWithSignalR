using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Category.Commands.Create;
using SignalRApp.Application.Features.Category.Commands.Delete;
using SignalRApp.Application.Features.Category.Commands.Update;
using SignalRApp.Application.Features.Category.Queries.GetAllCategories;
using SignalRApp.Application.Features.Category.Queries.GetCategoryById;

namespace SignalRApp.Api.Controllers;

public class CategoryController(IMediator mediator):BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await mediator.Send(new GetAllCategoriesQueryRequest());
        return CreateActionResult(response.Result);
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] GetCategoryByIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCategoryCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateCategoryCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromBody] DeleteCategoryCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}