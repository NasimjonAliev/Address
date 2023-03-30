using Microsoft.AspNetCore.Mvc;

namespace Address.Controllers;
public class RegionController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
