using Microsoft.AspNetCore.Mvc;

namespace Address.Controllers;
public class StreetController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
