using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpaAuth.Services.Interface;

namespace SpaAuth.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class MailerController : ControllerBase
    {
        ISimpleMailerService SimpleMailerService { get; set; }

        public MailerController(ISimpleMailerService simpleMailerService)
        {
            SimpleMailerService = simpleMailerService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            SimpleMailerService.SendEmail("sachaamm@gmail.com", "A TEST", "Hello world");

            return Ok("MailerController");
        }
    }
}
