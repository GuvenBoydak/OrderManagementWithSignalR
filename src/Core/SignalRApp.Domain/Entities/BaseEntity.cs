namespace SignalRApp.Domain.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? DeletedDate { get; set; }
    public bool IsDeleted { get; set; } = false;
}