using Microsoft.AspNetCore.Mvc;

namespace CarProject.WebUI.ViewComponents.AboutViewComponents
{
	public class _BecomeADriverComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
