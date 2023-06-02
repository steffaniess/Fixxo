using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using System.Reflection.Metadata.Ecma335;
using WebMVC.Models;

namespace WebMVC.Controllers
{
	public class ProductController : Controller
	{
		public async Task<IActionResult> Index(int productId)
		{
		using var client = new HttpClient();
			var result = await client.GetFromJsonAsync<ProductModel>();
			
			return View(result);
		}
	}

}






