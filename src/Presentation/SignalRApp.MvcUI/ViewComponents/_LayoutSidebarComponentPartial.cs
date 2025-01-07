using Microsoft.AspNetCore.Mvc;

namespace SignalRApp.MvcUI.ViewComponents;

public class _LayoutSidebarComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}