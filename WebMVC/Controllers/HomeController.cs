using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using WebMVC.Models;

namespace WebMVC.Controllers
{
	public class HomeController : Controller
	{
		public async Task<IActionResult> Index()
		{
			using var client = new HttpClient();
			var result = await client.GetFromJsonAsync<<IEnumerable<ProductModel>>();

			return View(result);
		}
	}
}
