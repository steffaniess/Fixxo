using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers.Repositories;
using WebApi.Helpers.Services;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly ProductRepository _productRepository;
		private readonly ProductService _productService;

		public ProductController(ProductRepository productRepository, ProductService productService)
		{
			_productRepository = productRepository;
			_productService = productService;
		}

		[Route("getall")]
		[HttpGet]
		public async Task <ActionResult> GetAllAsync()
		{
			return Ok(await _productService.GetAllAsync());
		}

		[Route("id")]
		[HttpGet]
		public async Task <IActionResult> GetByIdAsync(int id)
		{
			return Ok(await _productService.GetAsync(x => x.Id == id));
		}
		[Route("tag")]
		[HttpGet]
		public async Task<IActionResult> GetByTagAsync(int tag)
		{
			return Ok(await _productService.GetAllAsync(x => x.Tag == tag));
		}
	}
}
