using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Product.Commands.Create;
using SignalRApp.Application.Features.Product.Commands.Delete;
using SignalRApp.Application.Features.Product.Commands.Update;
using SignalRApp.Application.Features.Product.Queries.GetActiveProductCount;
using SignalRApp.Application.Features.Product.Queries.GetPassiveProductCount;
using SignalRApp.Application.Features.Product.Queries.GetProductById;
using SignalRApp.Application.Features.Product.Queries.GetProductCount;
using SignalRApp.Application.Features.Product.Queries.GetProductNameByMaxPrice;
using SignalRApp.Application.Features.Product.Queries.GetProductNameByMinPrice;
using SignalRApp.Application.Features.Product.Queries.GetProductsAveragePrice;
using SignalRApp.Application.Features.Product.Queries.GetProductsWithCategory;

namespace SignalRApp.Api.Controllers;

public class ProductsController(IMediator mediator) : BaseController
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

    [HttpGet("GetCount")]
    public async Task<IActionResult> GetCount()
    {
        var response = await mediator.Send(new GetProductCountQueryRequest());
        return CreateActionResult(response.Result);
    }

    [HttpGet("GetActiveCount")]
    public async Task<IActionResult> GetActiveCount()
    {
        var response = await mediator.Send(new GetActiveProductCountQueryRequest());
        return CreateActionResult(response.Result);
    }

    [HttpGet("GetPassiveCount")]
    public async Task<IActionResult> GetPassiveCount()
    {
        var response = await mediator.Send(new GetPassiveProductCountQueryRequest());
        return CreateActionResult(response.Result);
    }

    [HttpGet("GetProductsAveragePrice")]
    public async Task<IActionResult> GetProductsAveragePrice()
    {
        var response = await mediator.Send(new GetProductsAveragePriceQueryRequest());
        return CreateActionResult(response.Result);
    }

    [HttpGet("GetProductNameByMaxPrice")]
    public async Task<IActionResult> GetProductNameByMaxPrice()
    {
        var response = await mediator.Send(new GetProductNameByMaxPriceQueryRequest());
        return CreateActionResult(response.Result);
    }

    [HttpGet("GetProductNameByMinPrice")]
    public async Task<IActionResult> GetProductNameByMinPrice()
    {
        var response = await mediator.Send(new GetProductNameByMinPriceQueryRequest());
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