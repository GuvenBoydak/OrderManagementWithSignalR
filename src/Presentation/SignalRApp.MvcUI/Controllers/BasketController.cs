using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;

namespace SignalRApp.MvcUI.Controllers;

public class BasketController(BasketService basketService):Controller
{
    public async Task<IActionResult> Index()
    {
        var result = await basketService.GetAllAsync();
        if (result.IsSuccess)
        {
            return View(result.Data);
        }
        return View();
    }
}