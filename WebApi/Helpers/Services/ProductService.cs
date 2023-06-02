using System.Diagnostics;
using System.Linq.Expressions;
using WebApi.Contexts;
using WebApi.Helpers.Repositories;
using WebApi.Models.DTO;
using WebApi.Models.Entities;

namespace WebApi.Helpers.Services
{
	public class ProductService
	{
		private readonly DataContext _context;
		private readonly ProductRepository _productRepository;
		private readonly TagRepository _tagRepository;

		public ProductService(DataContext context, ProductRepository productRepository, TagRepository tagRepository)
		{
			_context = context;
			_productRepository = productRepository;
			_tagRepository = tagRepository;
		}
		public async Task<IEnumerable<Product>> GetAllAsync(Expression<Func<ProductEntity, bool>> expression)
		{
			try
			{
				var result = await _productRepository.GetAllAsync(expression);
				var products = new List<Product>();
				foreach (var entity in result)
				{
					Product product = entity;
					products.Add(product);
				}
				return products;
			}
			catch (Exception ex) { Debug.WriteLine(ex.Message); }
			return null!;
		}
		public async Task<IEnumerable<Product>> GetAllAsync()
		{
			try
			{
				var result = await _productRepository.GetAllAsync();
				var products = new List<Product>();
				foreach (var entity in result)
				{
					Product product = entity;
					products.Add(product);
				}
				return products;
			}
			catch (Exception ex) { Debug.WriteLine(ex.Message); }
			return null!;
		}
		public async Task<Product> GetAsync(Expression<Func<ProductEntity, bool>> expression)
		{
			var entity = await _productRepository.GetAsync(expression);
			Product product = entity;
			return product;
		}
	}
}


