namespace SignalRApp.MvcUI.Models.Response;

public record BookingResponse(int Id, string Name,string Phone,string Email,int PersonCount,DateTime Date);