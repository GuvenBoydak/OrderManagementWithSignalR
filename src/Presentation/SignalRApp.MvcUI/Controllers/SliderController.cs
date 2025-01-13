using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;
using SignalRApp.MvcUI.Models.Request.About;
using SignalRApp.MvcUI.Models.Request.Slider;

namespace SignalRApp.MvcUI.Controllers;

public class SliderController(SliderService sliderService,IMapper mapper):Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await sliderService.GetAllAsync();
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
    public async Task<IActionResult> Create(CreateSliderRequest createSliderRequest)
    {
        var result = await sliderService.AddAsync(createSliderRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    public async Task<IActionResult> Delete([FromRoute(Name = "Id")] int id)
    {
        var result = await sliderService.DeleteAsync(id);
        if (result)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
    
    [HttpGet]
    public async Task<IActionResult> Update([FromRoute(Name = "Id")] int id)
    {
        var result = await sliderService.GetByIdAsync(id);
        if (result.IsSuccess)
        {
            return View(mapper.Map<UpdateSliderRequest>(result.Data));
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateSliderRequest updateSliderRequest)
    {
        var result = await sliderService.UpdateAsync(updateSliderRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}