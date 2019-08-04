
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index() => View();

		[HttpPost] public IActionResult Basic(IFormFile fileUpload, IFormFile[] fileUploads) => RedirectToAction(nameof(Index));
		//[HttpPost]
		public IActionResult Direct(IFormFile[] fileUploads, string name)
		{
			var file = HttpContext.Request.Form.Files;

			return Ok("Upload Ok Shod .. !!!!");
		}
	}
}
