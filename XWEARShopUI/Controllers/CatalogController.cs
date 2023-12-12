using Microsoft.AspNetCore.Mvc;

namespace WebXWEAR.Controllers
{
	public class CatalogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
