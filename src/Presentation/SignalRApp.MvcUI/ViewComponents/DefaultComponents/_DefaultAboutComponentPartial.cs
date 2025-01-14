using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;

namespace SignalRApp.MvcUI.Views.Shared.DefaultComponents;

public class _DefaultAboutComponentPartial(AboutService aboutService):ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var result = await aboutService.GetAllAsync();
        if (result.IsSuccess)
        {
            return View(result.Data);
        }
        return View();
    }
}