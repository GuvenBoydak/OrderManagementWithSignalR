using Microsoft.AspNetCore.Mvc;

namespace SignalRApp.MvcUI.Views.Shared.UILayoutComponents;

public class _UILayoutNavBarComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}