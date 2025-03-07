using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;
using SignalRApp.MvcUI.Models.Request.Category;

namespace SignalRApp.MvcUI.Controllers;

public class CategoryController(CategoryService categoryService,IMapper mapper) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await categoryService.GetAllAsync();
        if (result.IsSuccess)
        {
            return View(result.Data);
        }
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCategoryRequest createCategoryRequest)
    {
        var result = await categoryService.AddAsync(createCategoryRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    public async Task<IActionResult> Delete([FromRoute(Name = "Id")] int id)
    {
        var result = await categoryService.DeleteAsync(id);
        if (result)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
    
    [HttpGet]
    public async Task<IActionResult> Update([FromRoute(Name = "Id")] int id)
    {
        var result = await categoryService.GetByIdAsync(id);
        if (result.IsSuccess)
        {
            return View(mapper.Map<UpdateCategoryRequest>(result.Data));
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateCategoryRequest updateCategoryRequest)
    {
        var result = await categoryService.UpdateAsync(updateCategoryRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}