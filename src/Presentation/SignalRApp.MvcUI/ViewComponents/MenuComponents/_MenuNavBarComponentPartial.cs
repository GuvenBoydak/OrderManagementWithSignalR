using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;

namespace SignalRApp.MvcUI.ViewComponents.MenuComponents;

public class _MenuNavBarComponentPartial():ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}