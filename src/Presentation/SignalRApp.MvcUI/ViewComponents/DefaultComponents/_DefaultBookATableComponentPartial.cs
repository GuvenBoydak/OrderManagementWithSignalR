using Microsoft.AspNetCore.Mvc;

namespace SignalRApp.MvcUI.Views.Shared.DefaultComponents;

public class _DefaultBookATableComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}