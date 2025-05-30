using Api.Interfaces;
using Api.Models;
using System.Net;
using System.Net.Mail;

namespace Api.Services;

public class EmailService : IEmailService
{
    public async Task SendEmail(Email email)
    {

        var mail = "example@outlook.com.br";
        var pw = "examplePassword";

        using var client = new SmtpClient("smtp-mail.outlook.com", 587);
        client.EnableSsl = true;
        client.Credentials = new NetworkCredential(mail, pw);

        var mailMessage = new MailMessage(from: mail, to: email.Receiver, subject: email.Subject, body: email.Message);

        await client.SendMailAsync(mailMessage);
    }
}