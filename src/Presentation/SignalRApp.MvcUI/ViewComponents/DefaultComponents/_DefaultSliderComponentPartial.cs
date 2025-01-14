using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;

namespace SignalRApp.MvcUI.Views.Shared.DefaultComponents;

public class _DefaultSliderComponentPartial(SliderService sliderService):ViewComponent
{
    
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var result = await sliderService.GetAllAsync();
        if (result.IsSuccess)
        {
            return View(result.Data);
        }

        return View();
    }
}