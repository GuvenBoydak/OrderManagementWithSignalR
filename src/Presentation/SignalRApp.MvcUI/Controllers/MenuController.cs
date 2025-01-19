using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;
using SignalRApp.MvcUI.Models.Request.Basket;

namespace SignalRApp.MvcUI.Controllers;

public class MenuController(ProductService productService,CategoryService categoryService,BasketService basketService):Controller
{
    public async Task<IActionResult> Index()
    {
        var products = await productService.GetProductsWithCategoryAsync();
        var categories = await categoryService.GetAllAsync();
        if (categories.IsSuccess)
        {
            ViewBag.Categories = categories.Data;
        }
        
        if (products.IsSuccess)
        {
            return View(products.Data);
        }
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> CreateBasket(CreateBasketRequest request)
    {
        var result = await basketService.AddAsync(request);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}