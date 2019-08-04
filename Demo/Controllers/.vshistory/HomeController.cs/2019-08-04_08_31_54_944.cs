
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Linq;

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

			IList<string> fileNmaes = new List<string>();

			foreach (IFormFile file in files)
			{
				string fileName = file.FileName;
				fileNmaes.Add(fileName);
			}

			string result = string.Join(",", fileNmaes.ToArray());

			return Ok($"{result} Upload Shod .. !!!!");
		}
	}
}
