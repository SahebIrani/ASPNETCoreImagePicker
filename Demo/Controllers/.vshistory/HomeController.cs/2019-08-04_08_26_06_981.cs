
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Linq;

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
			string[]? fileNmaes = null;
			foreach (IFormFile file in files)
			{
				string fileName = file.FileName;
				fileNmaes.Append(fileName);
			}

			return Ok($"{string.Join(",", fileNmaes.ToArray())} Upload Ok Shod .. !!!!");
		}
	}
}