using SignalRApp.Domain.Enums;

namespace SignalRApp.Domain.Entities;

public class Order:BaseEntity
{
    public string TableNumber { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime Date { get; set; }
    public decimal TotalPrice { get; set; }

    public List<OrderDetail> OrderDetails { get; set; }
}