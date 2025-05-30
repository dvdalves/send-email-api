using Api.Models;

namespace Api.Interfaces;

public interface IEmailService
{
    Task SendEmail(Email email);
}