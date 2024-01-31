using Microsoft.AspNetCore.Mvc;

namespace CarProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
