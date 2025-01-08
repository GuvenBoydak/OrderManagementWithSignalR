namespace SignalRApp.MvcUI.Models.Request.Booking;

public record CreateBookingRequest( string Name,string Phone,string Email,int PersonCount,DateTime Date);