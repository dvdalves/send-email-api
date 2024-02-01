using EnviarEmailAPI.Models;

namespace EnviarEmailAPI.Interfaces
{
    public interface IEmailService
    {
        Task EnviarEmail(Email email);
    }
}