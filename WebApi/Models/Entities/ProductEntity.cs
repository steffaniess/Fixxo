using Microsoft.AspNetCore.Mvc.Razor;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using WebApi.Models.DTO;

namespace WebApi.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImgUrl { get; set; } = null!;
        public string Tag { get; set; } = null!;
        public string Review { get; set; } = null!;

        public int Price { get; set; }
        public DateTime Added { get; set; }

        public int CategoryId { get; set; }
        public TagEntity Tags { get; set; } = null!;

        public static implicit operator Product(ProductEntity entity)
        {
            return new Product
            {
                ProductId = entity.ProductId,
                ProductName = entity.ProductName,
                Description = entity.Description,
                ImageUrl = entity.ImgUrl,
                Price = entity.Price,
                Tag = entity.Tag,
                Tags = entity.Tags,
                //Review = entity.Review,
                Added = entity.Added,
               // CategoryId = entity.CategoryId,

            };
        }
       
    }
}
