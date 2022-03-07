using Microsoft.AspNetCore.Mvc;
using Portfolio.Misc.Services;

namespace Homework2.Controllers
{
    public class EmailController : Controller
    {
        // GET
        public IActionResult Index([FromServices] IEmailService emailService)
        {
            emailService.SendEmail("asd@gmail.com", "Привет!");
            return Ok();
        }
    }
}