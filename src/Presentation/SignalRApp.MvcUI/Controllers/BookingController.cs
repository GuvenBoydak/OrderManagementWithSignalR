using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;
using SignalRApp.MvcUI.Models.Request.Booking;

namespace SignalRApp.MvcUI.Controllers;

public class BookingController(BookingService bookingService, IMapper mapper) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await bookingService.GetAllAsync();
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
    public async Task<IActionResult> Create(CreateBookingRequest createBookingRequest)
    {
        var result = await bookingService.AddAsync(createBookingRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    public async Task<IActionResult> Delete([FromRoute(Name = "Id")] int id)
    {
        var result = await bookingService.DeleteAsync(id);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Update([FromRoute(Name = "Id")] int id)
    {
        var result = await bookingService.GetByIdAsync(id);
        if (result.IsSuccess)
        {
            return View(mapper.Map<UpdateBookingRequest>(result.Data));
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateBookingRequest updateBookingRequest)
    {
        var result = await bookingService.UpdateAsync(updateBookingRequest);
        if (result)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}