using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Product.Commands.Create;
using SignalRApp.Application.Features.Product.Commands.Delete;
using SignalRApp.Application.Features.Product.Commands.Update;
using SignalRApp.Application.Features.Product.Queries.GetProductById;
using SignalRApp.Application.Features.Product.Queries.GetProductsWithCategory;

namespace SignalRApp.Api.Controllers;

public class ProductsController(IMediator mediator):BaseController
{
    [HttpGet("GetProductsWithCategory")]
    public async Task<IActionResult> GetProductsWithCategory()
    {
        var response = await mediator.Send(new GetProductsWithCategoryQueryRequest());
        return CreateActionResult(response.Result);
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] GetProductByIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateProductCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteProductCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    } 
}