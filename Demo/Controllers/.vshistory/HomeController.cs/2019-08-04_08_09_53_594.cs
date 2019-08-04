
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index() => View();

		[HttpPost] public IActionResult Basic(IFormFile fileUpload, IFormFile[] fileUploads) => RedirectToAction(nameof(Index));
		//[HttpPost]
		public IActionResult Direct(string name, IFormFile[] gwegwhwhw)
		{
			var file = HttpContext.Request.Form["File"];

			return Ok("Upload Ok Shod .. !!!!");
		}
	}
}
