using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;

namespace SignalRApp.MvcUI.Controllers;

public class BasketController(BasketService basketService):Controller
{
    public async Task<IActionResult> Index()
    {
        var result = await basketService.GetBasketByMenuTableIdAsync(1);
        if (result.IsSuccess)
        {
            return View(result.Data);
        }
        return View();
    }
    
    public async Task<IActionResult> Delete([FromRoute(Name = "Id")]int id)
    {
        var result = await basketService.DeleteAsync(id);
        if (result)
        {
            return View("Index");
        }

        return View();
    }
    
}