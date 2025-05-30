namespace Api.Models;

public class Email
{
    public required string Receiver { get; set; }
    public required string Subject { get; set; }
    public required string Message { get; set; }
}