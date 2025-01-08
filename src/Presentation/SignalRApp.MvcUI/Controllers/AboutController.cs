using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;
using SignalRApp.MvcUI.Models.Request.About;

namespace SignalRApp.MvcUI.Controllers;

public class AboutController(AboutService aboutService,IMapper mapper):Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await aboutService.GetAllAsync();
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
    public async Task<IActionResult> Create(CreateAboutRequest createAboutRequest)
    {
        var result = await aboutService.AddAsync(createAboutRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    public async Task<IActionResult> Delete([FromRoute(Name = "Id")] int id)
    {
        var result = await aboutService.DeleteAsync(id);
        if (result)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
    
    [HttpGet]
    public async Task<IActionResult> Update([FromRoute(Name = "Id")] int id)
    {
        var result = await aboutService.GetByIdAsync(id);
        if (result.IsSuccess)
        {
            return View(mapper.Map<UpdateAboutRequest>(result.Data));
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateAboutRequest updateAboutRequest)
    {
        var result = await aboutService.UpdateAsync(updateAboutRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}