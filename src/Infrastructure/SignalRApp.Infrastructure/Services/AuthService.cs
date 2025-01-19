using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.AppUser.Commands.LoginAppUser;
using SignalRApp.Application.Features.AppUser.Commands.RegiserAppUser;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Infrastructure.Services;

public class AuthService(UserManager<AppUser> userManager,IMapper mapper,SignInManager<AppUser> signInManager):IAuthService
{
    public async Task<ServiceResult> RegisterAsync(RegisterAppUserCommandRequest request)
    {
        var checkUser = await userManager.Users.FirstOrDefaultAsync(x => x.Email == request.Email);
        if (checkUser is not null)
        {
            return ServiceResult.Failure(AppUserConstant.ExistUser);
        }

        var appUser = mapper.Map<AppUser>(request);
        var result = await userManager.CreateAsync(appUser, request.Password);
        if (!result.Succeeded)
        {
            return ServiceResult.Failure(AppUserConstant.FailedRegistration);
        }

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult<bool>> LoginAsync(LoginAppUserCommandRequest request)
    {
        var result = await signInManager.PasswordSignInAsync(request.UserName, request.Password,false,false);
        if (!result.Succeeded)
        {
            return ServiceResult<bool>.Failure(AppUserConstant.FailedLogin);
        }

        return ServiceResult<bool>.Success(result.Succeeded);
    }
}