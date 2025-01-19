using MediatR;
using Microsoft.AspNetCore.SignalR;
using SignalRApp.Application.Features.Booking.Queries.GetAllBookings;
using SignalRApp.Application.Features.Category.Queries.GetActiveCategoryCount;
using SignalRApp.Application.Features.Category.Queries.GetCategoryCount;
using SignalRApp.Application.Features.Category.Queries.GetPassiveCategoryCount;
using SignalRApp.Application.Features.Notification.Queries.GetNotificationCountByIsRead;
using SignalRApp.Application.Features.Notification.Queries.GetNotificationsByIsRead;
using SignalRApp.Application.Features.Order.Queries.GetTodayTotalPrice;
using SignalRApp.Application.Features.Order.Queries.GetTotalOrder;
using SignalRApp.Application.Features.Order.Queries.GetTotalPriceOrder;
using SignalRApp.Application.Features.Product.Queries.GetActiveProductCount;
using SignalRApp.Application.Features.Product.Queries.GetPassiveProductCount;
using SignalRApp.Application.Features.Product.Queries.GetProductCount;
using SignalRApp.Application.Features.Product.Queries.GetProductNameByMaxPrice;
using SignalRApp.Application.Features.Product.Queries.GetProductNameByMinPrice;
using SignalRApp.Application.Features.Product.Queries.GetProductsAveragePrice;

namespace SignalRApp.Api.Hubs;

public class SignalRHub(IMediator mediator):Hub
{
    public static int ClientCount { get; set; } = 0;
    public async Task SendStatistic()
    {
        var categoryCount = await mediator.Send(new GetCategoryCountQueryRequest());
        var productCount = await mediator.Send(new GetProductCountQueryRequest());
        var activeCategoryCount = await mediator.Send(new GetActiveCategoryCountQueryRequest());
        var passiveCategoryCount = await mediator.Send(new GetPassiveCategoryCountQueryRequest());
        var maxPriceProductName = await mediator.Send(new GetProductNameByMaxPriceQueryRequest());
        var minPriceProductName = await mediator.Send(new GetProductNameByMinPriceQueryRequest());
        var activeProducts = await mediator.Send(new GetActiveProductCountQueryRequest());
        var passiveProducts = await mediator.Send(new GetPassiveProductCountQueryRequest());
        var averageProductPrice = await mediator.Send(new GetProductsAveragePriceQueryRequest());
        var todayTotalOrderPrice = await mediator.Send(new GetTodayTotalPriceQueryRequest());
        var totalOrderPrice = await mediator.Send(new GetTotalPriceOrderQueryRequest());
        var totalOrder = await mediator.Send(new GetTotalOrderQueryRequest());
            

        var dashboardData = new
        {
            CategoryCount = categoryCount.Result.Data,
            ProductCount = productCount.Result.Data,
            ActiveCategoryCount = activeCategoryCount.Result.Data,
            PassiveCategoryCount = passiveCategoryCount.Result.Data,
            MaxPriceProductName = maxPriceProductName.Result.Data,
            MinPriceProductName = minPriceProductName.Result.Data,
            ActiveProducts = activeProducts.Result.Data,
            PassiveProducts = passiveProducts.Result.Data,
            AverageProductPrice = averageProductPrice.Result.Data,
            TodayTotalOrderPrice = todayTotalOrderPrice.Result.Data,
            TotalOrderPrice = totalOrderPrice.Result.Data,
            TotalOrder = totalOrder.Result.Data
        };
        
        await Clients.All.SendAsync("ReceiveStatistic", dashboardData);
    }

    public async Task SendProgressStatistic()
    {
        var totalOrderPrice = await mediator.Send(new GetTotalPriceOrderQueryRequest());
        var totalOrder = await mediator.Send(new GetTotalOrderQueryRequest());
        
        var progressStatisticData = new
        {
            TotalOrderPrice = totalOrderPrice.Result.Data,
            TotalOrder = totalOrder.Result.Data
        };
        
        await Clients.All.SendAsync("ReceiveProgressStatistic", progressStatisticData);
    }

    public async Task GetBookingList()
    {
        var booking = await mediator.Send(new GetAllBookingsQueryRequest());
        Clients.All.SendAsync("sendBookings", booking.Result.Data);
    }
    
    public async Task SendNotification()
    {
        var unReadNotificationCount = await mediator.Send(new GetNotificationCountByIsReadQueryRequest(false));
        var unReadNotifications = await mediator.Send(new GetNotificationsByIsReadQueryRequest(false));
        
        var notification = new
        {
            UnReadNotificationCount = unReadNotificationCount.Result.Data,
            UnReadNotifications = unReadNotifications.Result.Data
        };
        
        Clients.All.SendAsync("ReceiveNotification",notification);
    }
    
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }

    public async override Task OnConnectedAsync()
    {
        ClientCount++;
        await Clients.All.SendAsync("ReceiveClientCount", ClientCount);
        await base.OnConnectedAsync();
    }

    public async override Task OnDisconnectedAsync(Exception? exception)
    {
        ClientCount--;
        await Clients.All.SendAsync("ReceiveClientCount", ClientCount);
        await base.OnDisconnectedAsync(exception);
    }
}