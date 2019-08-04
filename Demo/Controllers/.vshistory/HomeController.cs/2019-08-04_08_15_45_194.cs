
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace Demo.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index() => View();

		[HttpPost] public IActionResult Basic(IFormFile fileUpload, IFormFile[] fileUploads) => RedirectToAction(nameof(Index));
		//[HttpPost]
		public IActionResult Direct(IList<IFormFile> fileUpload, string name)
		{
			var file = HttpContext.Request.Form["File"];

			return Ok("Upload Ok Shod .. !!!!");
		}
	}
}
