using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;


[Authorize]
public class DefaultController : Controller
{

    [Route("/")]
    public IActionResult Home()
    {
        return View();
    }


    [Route("/contact")]
    public IActionResult Contact()
    {
        return View();
    }

    [Route("/404")]
    public IActionResult Error()
    {
        return View();
    }

}
