using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {

        [Route("/security")]
        public IActionResult Security()
        {
            return View();
        }

        public IActionResult ChangePass()
        {
            return Ok();
        }
    }
}
