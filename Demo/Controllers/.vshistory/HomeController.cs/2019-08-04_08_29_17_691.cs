
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Text;

namespace Demo.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index() => View();

		[HttpPost] public IActionResult Basic(IFormFile fileUpload, IFormFile[] fileUploads) => RedirectToAction(nameof(Index));
		//[HttpPost]
		public IActionResult Direct(string name)
		{
			IFormFileCollection files = HttpContext.Request.Form.Files;

			StringBuilder fileNmaes = null;

			foreach (IFormFile file in files)
			{
				string fileName = file.FileName;
				fileNmaes.Append(fileName);
			}

			string result = string.Join(",", fileNmaes.ToString());

			return Ok($"{result} Upload Shod .. !!!!");
		}
	}
}
