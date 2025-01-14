using Microsoft.AspNetCore.Mvc;

namespace SignalRApp.MvcUI.Views.Shared.UILayoutComponents;

public class _UILayoutHeadComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}