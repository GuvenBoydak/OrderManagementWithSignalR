namespace SignalRApp.Domain.Entities;

public class Contact:BaseEntity
{
    public string Location { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string FooterDescription { get; set; }
}