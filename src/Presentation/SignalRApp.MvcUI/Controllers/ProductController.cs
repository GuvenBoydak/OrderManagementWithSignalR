using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SignalRApp.MvcUI.ConsumerApiServices;
using SignalRApp.MvcUI.Models.Request.Product;

namespace SignalRApp.MvcUI.Controllers;

public class ProductController(ProductService productService,CategoryService categoryService,IMapper mapper): Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await productService.GetProductsWithCategoryAsync();
        if (result.IsSuccess)
        {
            return View(result.Data);
        }
        return View();
    }
    
    [HttpGet]
    public async Task<IActionResult> Create()
    {
        var result = await categoryService.GetAllAsync();
        if (result.IsSuccess)
        {
            List<SelectListItem> categoryItems =
                (from x in result.Data select new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            ViewBag.v = categoryItems;
            return View();
        }
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductRequest createProductRequest)
    {
        var result = await productService.AddAsync(createProductRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    public async Task<IActionResult> Delete([FromRoute(Name = "Id")] int id)
    {
        var result = await productService.DeleteAsync(id);
        if (result)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
    
    [HttpGet]
    public async Task<IActionResult> Update([FromRoute(Name = "Id")] int id)
    {
        var result = await productService.GetByIdAsync(id);
        if (result.IsSuccess)
        {
            var resultCategory = await categoryService.GetAllAsync();
            if (resultCategory.IsSuccess)
            {
                List<SelectListItem> categoryItems =
                    (from x in resultCategory.Data select new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
                ViewBag.v = categoryItems;
                
                return View(mapper.Map<UpdateProductRequest>(result.Data));
            }
            return View();
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateProductRequest updateCategoryRequest)
    {
        var result = await productService.UpdateAsync(updateCategoryRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}