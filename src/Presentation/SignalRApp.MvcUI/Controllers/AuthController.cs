using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.MvcUI.ConsumerApiServices;
using SignalRApp.MvcUI.Models.Request.AppUser;


namespace SignalRApp.MvcUI.Controllers;

public class AuthController(AuthService authService):Controller
{
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Register(CreateAppUserRequest request)
    {
        var result = await authService.ReqisterAsync(request);
        if (result)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
    
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginAppUserRequest request)
    {
        var result = await authService.LoginAsync(request);
        if (result)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
    
}