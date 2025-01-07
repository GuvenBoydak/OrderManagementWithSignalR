using Microsoft.AspNetCore.Mvc;

namespace SignalRApp.MvcUI.ViewComponents;

public class _LayoutNavbarComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}