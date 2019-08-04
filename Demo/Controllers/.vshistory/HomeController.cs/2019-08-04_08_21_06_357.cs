
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
			IFormFileCollection files = HttpContext.Request.Form.Files;
			foreach (IFormFile file in files)
			{
				string fileName = file.FileName;
			}

			return Ok("Upload Ok Shod .. !!!!");
		}
	}
}
