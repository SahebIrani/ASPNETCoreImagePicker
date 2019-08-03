using Demo.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.Diagnostics;

namespace Demo.Controllers
{
	public class HomeController : Controller
	{
		public HomeController(ILogger<HomeController> logger) => _logger = logger;
		private readonly ILogger<HomeController> _logger;

		public IActionResult Index() => View();

		public IActionResult Privacy() => View();

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });



		public IActionResult Coba1(IFormFile fileUpload, IFormFile[] fileUploads) => RedirectToAction(nameof(Coba1));

		public IActionResult Coba2(IFormFile[] fileUploadAjax/*, string testParam*/)
		{
			return Ok("Upload Ok Shod .. !!!!");
		}
	}
}