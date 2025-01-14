using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;

namespace SignalRApp.MvcUI.Views.Shared.DefaultComponents;

public class _DefaultTestimonialComponentPartial(TestimonialService testimonialService):ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var result = await testimonialService.GetAllAsync();
        if (result.IsSuccess)
        {
            return View(result.Data);
        }
        return View();
    }
}