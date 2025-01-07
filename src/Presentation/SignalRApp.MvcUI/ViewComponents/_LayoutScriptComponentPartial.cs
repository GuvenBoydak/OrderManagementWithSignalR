using Microsoft.AspNetCore.Mvc;

namespace SignalRApp.MvcUI.ViewComponents;

public class _LayoutScriptComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}