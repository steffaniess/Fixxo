using Microsoft.AspNetCore.Mvc;
using WebMVC.ViewModels;

namespace WebMVC.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			var viewModel = new ContactViewModel();
			return View(viewModel);
		}

		[HttpPost]
		public async Task<IActionResult> Index(ContactViewModel model)
		{
			if(ModelState.IsValid)
			{
				using var http = new HttpClient();
				
			}
		}
	}
}
