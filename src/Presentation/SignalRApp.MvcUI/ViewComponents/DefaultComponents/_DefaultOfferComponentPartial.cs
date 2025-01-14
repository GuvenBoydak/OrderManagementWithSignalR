using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;

namespace SignalRApp.MvcUI.Views.Shared.DefaultComponents;

public class _DefaultOfferComponentPartial(DiscountService discountService):ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var result = await discountService.GetAllAsync();
        if (result.IsSuccess)
        {
            return View(result.Data);
        }
        return View();
    }
}