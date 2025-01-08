using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;
using SignalRApp.MvcUI.Models.Request.Testimonial;

namespace SignalRApp.MvcUI.Controllers;

public class TestimonialController(TestimonialService testimonialService, IMapper mapper) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await testimonialService.GetAllAsync();
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
    public async Task<IActionResult> Create(CreateTestimonialRequest createTestimonialRequest)
    {
        var result = await testimonialService.AddAsync(createTestimonialRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    public async Task<IActionResult> Delete([FromRoute(Name = "Id")] int id)
    {
        var result = await testimonialService.DeleteAsync(id);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Update([FromRoute(Name = "Id")] int id)
    {
        var result = await testimonialService.GetByIdAsync(id);
        if (result.IsSuccess)
        {
            return View(mapper.Map<UpdateTestimonialRequest>(result.Data));
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateTestimonialRequest updateTestimonialRequest)
    {
        var result = await testimonialService.UpdateAsync(updateTestimonialRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}