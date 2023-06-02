namespace WebApi.Models.DTO
{
	public class Tag
	{
        public int TagId { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Tags { get; set; } = null!;
        public DateTime Created { get; set; }

    }
}
