namespace SignalRApp.Domain.Entities;

public class Product:BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
    public List<Basket> Baskets { get; set; }
}