using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LinuxTECHIESpirals.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace LinuxTECHIESpirals.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
    
    public IActionResult Contact()
    {
        ViewBag.submitted = false;
        return View();
    }

    [HttpPost]
    public IActionResult Contact(CustomerContact model)
    {

        ViewBag.submitted = true;
        return View();
    }

    public IActionResult Services()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult SLA()
    {
        return View();
    }
    public IActionResult SAASTOS()
    {
        return View();
    }

    public IActionResult TOS()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
