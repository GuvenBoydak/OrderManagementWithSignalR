using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;
using SignalRApp.MvcUI.Models.Request.Discount;

namespace SignalRApp.MvcUI.Controllers;

public class DiscountController(DiscountService discountService, IMapper mapper) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await discountService.GetAllAsync();
        if (result.IsSuccess)
        {
            return View(result.Data);
        }

        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateDiscountRequest createDiscountRequest)
    {
        var result = await discountService.AddAsync(createDiscountRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    public async Task<IActionResult> Delete([FromRoute(Name = "Id")] int id)
    {
        var result = await discountService.DeleteAsync(id);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Update([FromRoute(Name = "Id")] int id)
    {
        var result = await discountService.GetByIdAsync(id);
        if (result.IsSuccess)
        {
            return View(mapper.Map<UpdateDiscountRequest>(result.Data));
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateDiscountRequest updateDiscountRequest)
    {
        var result = await discountService.UpdateAsync(updateDiscountRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}