namespace EnviarEmailAPI.Models
{
    public class Email
    {
        public required string Destinatario { get; set; }
        public required string Assunto { get; set; }
        public required string Mensagem { get; set; }
    }
}