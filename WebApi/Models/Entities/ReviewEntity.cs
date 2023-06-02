using System.ComponentModel.DataAnnotations;
using WebApi.Models.DTO;

namespace WebApi.Models.Entities
{
	public class ReviewEntity
	{
		[Key]
		public int ReviewId { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Tags { get; set; } = null!;
        public DateTime Created { get; set; }

        public static implicit operator Review(ReviewEntity entity)
        {
            return new Review
            {   
                ReviewId = entity.ReviewId,
                UserName = entity.UserName,
                Email = entity.Email,   
                Tags = entity.Tags,
                Created = entity.Created,
            };
        }

    }
}
