using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;
using SignalRApp.MvcUI.Models.Request.Notification;

namespace SignalRApp.MvcUI.Controllers;

public class NotificationController(NotificationService notificationService,IMapper mapper):Controller
{
    public async Task<IActionResult> Index()
    {
        var result = await notificationService.GetAllAsync();
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
    public async Task<IActionResult> Create(CreateNotificationRequest  request)
    {
        var result = await notificationService.AddAsync(request);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
    
    [HttpGet]
    public async Task<IActionResult> Update([FromRoute(Name = "Id")] int id)
    {
        var result = await notificationService.GetByIdAsync(id);
        if (result.IsSuccess)
        {
            return View(mapper.Map<UpdateNotificationRequest>(result.Data));
        }
        return View();
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateNotificationRequest  request)
    {
        var result = await notificationService.UpdateAsync(request);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
    
    public async Task<IActionResult> Delete([FromRoute(Name = "Id")] int id)
    {
        var result = await notificationService.DeleteAsync(id);
        if (result)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
    
}