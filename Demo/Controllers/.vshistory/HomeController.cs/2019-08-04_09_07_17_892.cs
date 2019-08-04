
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Linq;

namespace Demo.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index() => View();

		[HttpPost]
		public IActionResult Basic(IFormFile fileUpload, IFormFile[] fileUploads)
		{
			if (fileUpload == null || !fileUploads.Any())
				return RedirectToAction(nameof(Index));

			IList<string> fileNmaes = new List<string>
			{
				fileUpload.FileName
			};

			foreach (IFormFile file in fileUploads)
			{
				string fileName = file.FileName;
				fileNmaes.Add(fileName);
			}

			return Ok(fileNmaes);
		}

		public IActionResult Direct(string? testParam)
		{
			IFormFileCollection files = HttpContext.Request.Form.Files;

			IList<string> fileNmaes = new List<string>();

			foreach (IFormFile file in files)
			{
				string fileName = file.FileName;
				fileNmaes.Add(fileName);
			}

			string result = string.Join(",", fileNmaes.ToArray());

			return Ok($"{result} | {testParam}");
		}
	}
}
