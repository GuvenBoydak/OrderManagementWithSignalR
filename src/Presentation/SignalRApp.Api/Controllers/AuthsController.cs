using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.AppUser.Commands.LoginAppUser;
using SignalRApp.Application.Features.AppUser.Commands.RegiserAppUser;

namespace SignalRApp.Api.Controllers;

public class AuthsController(IMediator mediator):BaseController
{
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterAppUserCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
    
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginAppUserCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}