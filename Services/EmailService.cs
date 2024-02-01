using EnviarEmailAPI.Interfaces;
using EnviarEmailAPI.Models;
using System.Net;
using System.Net.Mail;

namespace EnviarEmailAPI.Services
{
    public class EmailService : IEmailService
    {
        public async Task EnviarEmail(Email email)
        {
            // Configure o email e a senha do remetente
            var mail = "exemplo@outlook.com.br";
            var pw = "exemplosenha";

            using (var client = new SmtpClient("smtp-mail.outlook.com", 587))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(mail, pw);

                var mailMessage = new MailMessage(from: mail, to: email.Destinatario, subject: email.Assunto, body: email.Mensagem);

                await client.SendMailAsync(mailMessage);
            }
        }
    }
}