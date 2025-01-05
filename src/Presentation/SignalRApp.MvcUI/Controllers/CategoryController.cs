using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;

namespace SignalRApp.MvcUI.Controllers;

public class CategoryController(CategoryService categoryService) : Controller
{
    public async Task<IActionResult> Index()
    {
        var result = await categoryService.GetAllAsync();
        return View(result);
    }
}