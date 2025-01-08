using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;
using SignalRApp.MvcUI.Models.Request.Contact;

namespace SignalRApp.MvcUI.Controllers;

public class ContactController(ContactService contactService, IMapper mapper) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await contactService.GetAllAsync();
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
    public async Task<IActionResult> Create(CreateContactRequest createContactRequest)
    {
        var result = await contactService.AddAsync(createContactRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    public async Task<IActionResult> Delete([FromRoute(Name = "Id")] int id)
    {
        var result = await contactService.DeleteAsync(id);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Update([FromRoute(Name = "Id")] int id)
    {
        var result = await contactService.GetByIdAsync(id);
        if (result.IsSuccess)
        {
            return View(mapper.Map<UpdateContactRequest>(result.Data));
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateContactRequest updateContactRequest)
    {
        var result = await contactService.UpdateAsync(updateContactRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}