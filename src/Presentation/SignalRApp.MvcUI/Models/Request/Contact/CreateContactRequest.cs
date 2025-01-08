namespace SignalRApp.MvcUI.Models.Request.Contact;

public record CreateContactRequest(string Location,string Phone,string Email,string FooterDescription);