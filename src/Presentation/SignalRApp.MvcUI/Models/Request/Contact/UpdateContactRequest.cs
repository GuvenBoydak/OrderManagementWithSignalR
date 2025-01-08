namespace SignalRApp.MvcUI.Models.Request.Contact;

public record UpdateContactRequest(int Id,string Location,string Phone,string Email,string FooterDescription);