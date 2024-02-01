using EnviarEmailAPI.Interfaces;
using EnviarEmailAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnviarEmailAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : Controller
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> EnviarEmail([FromBody] Email email)
        {
            await _emailService.EnviarEmail(email);
            return Ok();
        }
    }
}