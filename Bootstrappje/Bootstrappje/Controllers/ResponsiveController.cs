using Microsoft.AspNetCore.Mvc;

namespace Bootstrappje.Controllers;

public class ResponsiveController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}