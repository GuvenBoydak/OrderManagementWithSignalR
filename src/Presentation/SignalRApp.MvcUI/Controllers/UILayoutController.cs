using Microsoft.AspNetCore.Mvc;

namespace SignalRApp.MvcUI.Controllers;

public class UILayoutController:Controller
{
    public IActionResult Index()
    {
        return View();
    }
}