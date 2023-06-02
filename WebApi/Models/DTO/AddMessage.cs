using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.DTO
{
	public class AddMessage
	{
		[MinLength(2)]
		[Required]
        public string Name { get; set; }

		[RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
		[Required]
		public string Message { get; set; }

		[Required]
		public string Email { get; set; }
    }
}
