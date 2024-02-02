using Microsoft.AspNetCore.Mvc;

namespace CarProject.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmetler";
            ViewBag.v1 = "Hizmetlerimiz";
            return View();
        }
    }
}
