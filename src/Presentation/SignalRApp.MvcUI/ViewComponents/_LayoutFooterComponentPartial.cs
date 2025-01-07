using Microsoft.AspNetCore.Mvc;

namespace SignalRApp.MvcUI.ViewComponents;

public class _LayoutFooterComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}