using Microsoft.AspNetCore.Mvc;

namespace HomeTaskWebServer.Controllers;

public class ContactController : Controller
{
    public IActionResult Form()
    {
        return View();
    } 
}