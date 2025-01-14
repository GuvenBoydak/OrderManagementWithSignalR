using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;

namespace SignalRApp.MvcUI.Views.Shared.UILayoutComponents;

public class _UILayoutFooterComponentPartial(ContactService contactService):ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var result = await contactService.GetAllAsync();
        if (result.IsSuccess)
        {
            return View(result.Data);
        }
        return View();
    }
}