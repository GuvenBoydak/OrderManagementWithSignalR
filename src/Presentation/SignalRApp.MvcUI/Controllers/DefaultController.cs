using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;
using SignalRApp.MvcUI.Models.Request.Message;

namespace SignalRApp.MvcUI.Controllers;

public class DefaultController(MessageService messageService) : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public PartialViewResult SendMessage()
    {
        return PartialView();
    }

    [HttpPost]
    public async Task<IActionResult> SendMessage(CreateMessageRequest request)
    {
        var result = await messageService.AddAsync(request);
        if (result)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
}