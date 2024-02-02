using Microsoft.AspNetCore.Mvc;

namespace CarProject.WebUI.ViewComponents.DefaultViewComponents
{
	public class _DefaultStaticticsComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
