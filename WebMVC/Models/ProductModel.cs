namespace WebMVC.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Tag { get; set; } = null!;
        public int Review { get; set; }
        public decimal Price { get; set; }
        public DateTime Added { get; set; }
        public int TagId { get; set; }
        public TagModel Tags { get; set; } = null!;
    }
}
