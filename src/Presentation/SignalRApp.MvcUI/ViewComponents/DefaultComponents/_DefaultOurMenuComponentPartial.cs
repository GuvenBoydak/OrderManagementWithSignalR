using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;

namespace SignalRApp.MvcUI.Views.Shared.DefaultComponents;

public class _DefaultOurMenuComponentPartial(ProductService productService,CategoryService categoryService):ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var products = await productService.GetProductsWithCategoryAsync();
        var categories = await categoryService.GetAllAsync();
        if (categories.IsSuccess)
        {
            ViewBag.Categories = categories.Data;
        }
        
        if (products.IsSuccess)
        {
            return View(products.Data);
        }

        return View();
    }
}