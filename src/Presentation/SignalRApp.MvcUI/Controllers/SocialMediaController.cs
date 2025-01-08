using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;
using SignalRApp.MvcUI.Models.Request.SocialMedia;

namespace SignalRApp.MvcUI.Controllers;

public class SocialMediaController(SocialMediaService socialMediaService, IMapper mapper) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await socialMediaService.GetAllAsync();
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
    public async Task<IActionResult> Create(CreateSocialMediaRequest createSocialMediaRequest)
    {
        var result = await socialMediaService.AddAsync(createSocialMediaRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    public async Task<IActionResult> Delete([FromRoute(Name = "Id")] int id)
    {
        var result = await socialMediaService.DeleteAsync(id);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Update([FromRoute(Name = "Id")] int id)
    {
        var result = await socialMediaService.GetByIdAsync(id);
        if (result.IsSuccess)
        {
            return View(mapper.Map<UpdateSocialMediaRequest>(result.Data));
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateSocialMediaRequest updateSocialMediaRequest)
    {
        var result = await socialMediaService.UpdateAsync(updateSocialMediaRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}