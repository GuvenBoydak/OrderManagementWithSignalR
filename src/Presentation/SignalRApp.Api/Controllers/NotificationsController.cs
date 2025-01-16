using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRApp.Application.Features.Notification.Commands.Create;
using SignalRApp.Application.Features.Notification.Commands.Delete;
using SignalRApp.Application.Features.Notification.Commands.Update;
using SignalRApp.Application.Features.Notification.Queries.GetAllNotifications;
using SignalRApp.Application.Features.Notification.Queries.GetNotificationById;
using SignalRApp.Application.Features.Notification.Queries.GetNotificationCountByIsRead;
using SignalRApp.Application.Features.Notification.Queries.GetNotificationsByIsRead;

namespace SignalRApp.Api.Controllers;

public class NotificationsController(IMediator mediator) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await mediator.Send(new GetAllNotificationsQueryRequest());
        return CreateActionResult(response.Result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] GetNotificationByIdQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpGet("GetNotificationCountByIsRead")]
    public async Task<IActionResult> GetNotificationCountByIsRead(
        [FromRoute] GetNotificationCountByIsReadQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpGet("GetNotificationsByIsRead")]
    public async Task<IActionResult> GetNotificationsByIsRead([FromRoute] GetNotificationsByIsReadQueryRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateNotificationCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> Create([FromBody] UpdateNotificationCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteNotificationCommandRequest request)
    {
        var response = await mediator.Send(request);
        return CreateActionResult(response.Result);
    }
}