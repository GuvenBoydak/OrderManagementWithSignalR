using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Category.Commands.Create;
using SignalRApp.Application.Features.Category.Commands.Delete;
using SignalRApp.Application.Features.Category.Commands.Update;
using SignalRApp.Application.Features.Category.Queries.GetActiveCategoryCount;
using SignalRApp.Application.Features.Category.Queries.GetAllCategories;
using SignalRApp.Application.Features.Category.Queries.GetCategoryById;
using SignalRApp.Application.Features.Category.Queries.GetCategoryCount;
using SignalRApp.Application.Features.Category.Queries.GetPassiveCategoryCount;

namespace SignalRApp.Api.Controllers;

public class CategoriesController(IMediator mediator) : BaseController
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

    [HttpGet("GetCount")]
    public async Task<IActionResult> GetCount()
    {
        var response = await mediator.Send(new GetCategoryCountQueryRequest());
        return CreateActionResult(response.Result);
    }

    [HttpGet("GetActiveCount")]
    public async Task<IActionResult> GetActiveCount()
    {
        var response = await mediator.Send(new GetActiveCategoryCountQueryRequest());
        return CreateActionResult(response.Result);
    }

    [HttpGet("GetPassiveCount")]
    public async Task<IActionResult> GetPassiveCount()
    {
        var response = await mediator.Send(new GetPassiveCategoryCountQueryRequest());
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

    [HttpDelete("{Id:int}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteCategoryCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}