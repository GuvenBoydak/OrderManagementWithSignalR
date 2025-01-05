namespace SignalRApp.Domain.Entities;

public class Discount:BaseEntity
{
    public string Title { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}