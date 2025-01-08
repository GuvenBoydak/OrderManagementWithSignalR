namespace SignalRApp.MvcUI.Models.Request.Booking;

public record UpdateBookingRequest( int Id,string Name,string Phone,string Email,int PersonCount,DateTime Date);