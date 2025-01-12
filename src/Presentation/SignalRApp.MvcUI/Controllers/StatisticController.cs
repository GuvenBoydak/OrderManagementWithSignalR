using Microsoft.AspNetCore.Mvc;

namespace SignalRApp.MvcUI.Controllers;

public class StatisticController:Controller
{
    public IActionResult Index()
    {
        return View();
    }
}