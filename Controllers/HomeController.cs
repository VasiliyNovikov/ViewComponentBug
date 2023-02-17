using Microsoft.AspNetCore.Mvc;

namespace ViewComponentBug.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
}