using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;
using SignalRApp.MvcUI.Models.Request.Booking;

namespace SignalRApp.MvcUI.Controllers;

public class BookATableController(BookingService bookingService):Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Index(CreateBookingRequest createBookingRequest)
    {
        var result = await bookingService.AddAsync(createBookingRequest);
        if (result)
        {
            return RedirectToAction("Index", "Default");
        }

        return View();
    }
}
