using Microsoft.AspNetCore.Mvc;

namespace SignalRApp.MvcUI.ViewComponents;

public class _LayouHeaderComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}