using Microsoft.AspNetCore.Mvc;

namespace CarProject.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
