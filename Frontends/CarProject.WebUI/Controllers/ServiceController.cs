using Microsoft.AspNetCore.Mvc;

namespace CarProject.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
