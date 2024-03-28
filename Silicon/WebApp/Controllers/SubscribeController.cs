using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebApi.Models;

namespace WebApp.Controllers;

public class SubscribeController(HttpClient http) : Controller
{

    private readonly HttpClient _http = http;

    [HttpPost]
    public async Task<IActionResult> Register(SubscribeForm form)
    {
        if (ModelState.IsValid)
        {
            var content = new StringContent(JsonConvert.SerializeObject(form), Encoding.UTF8, "application/json");
            var response = await _http.PostAsync("https://localhost:7093/api/Subcribe", content);
            if (response.IsSuccessStatusCode)
            {
                TempData["Status"] = "You are now subscribed, thank you!";
                return RedirectToAction("Home", "Default", "subscribe");
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                TempData["Status"] = "You are already subscribed!";
                return RedirectToAction("Home", "Default", "subscribe");
            }

        }
        TempData["Status"] = "Something went wrong. Please try again!";
        return RedirectToAction("Home", "Default", "subscribe");
    }
}
