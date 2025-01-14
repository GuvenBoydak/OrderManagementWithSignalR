namespace SignalRApp.Domain.Entities;

public class MenuTable:BaseEntity
{
    public string Name { get; set; }
    public List<Basket> Baskets { get; set; }
}