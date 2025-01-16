namespace SignalRApp.Domain.Entities;

public class Notification:BaseEntity
{
    public string Description { get; set; }
    public string Type { get; set; }
    public string ImageUrl { get; set; }
    public bool IsRead { get; set; }
}