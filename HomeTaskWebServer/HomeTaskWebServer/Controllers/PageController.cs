using Microsoft.AspNetCore.Mvc;

namespace HomeTaskWebServer.Controllers;

public class PageController : Controller
{
    public IActionResult Blog()
    {
        return View();
    }
    
    public IActionResult Portfolio()
    {
        return View();
    }
    
    public IActionResult Services()
    {
        return View();
    } 
}