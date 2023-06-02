namespace WebApi.Models.DTO
{
	public class Review
	{
        public int ReviewId { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Tags { get; set; } = null!;
        public DateTime Created { get; set; }
    }
}
