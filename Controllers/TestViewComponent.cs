using Microsoft.AspNetCore.Mvc;

namespace ViewComponentBug.Controllers;

public class TestViewComponent : ViewComponent
{
    public IViewComponentResult Invoke() => View();
}