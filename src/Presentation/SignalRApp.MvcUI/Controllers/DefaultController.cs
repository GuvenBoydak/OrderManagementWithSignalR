using Microsoft.AspNetCore.Mvc;

namespace SignalRApp.MvcUI.Controllers;

public class DefaultController:Controller
{
    public IActionResult Index()
    {
        return View();
    }
}