using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApi.Models.Entities
{
	public class TagEntity
	{
		[Key]
		public int CategoryId { get; set; }
		public string CategoryName { get; set; } = null!;

		[JsonIgnore] // products
        public ICollection<ProductEntity> Producs { get; set; } = new HashSet<ProductEntity>();




    }
}
