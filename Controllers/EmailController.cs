using Api.Interfaces;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class EmailController(IEmailService emailService) : Controller
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Email email)
    {
        await emailService.SendEmail(email);
        return Ok();
    }
}