using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities;

namespace WebApi.Contexts
{
    public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}
		public DbSet<ProductEntity> Product { get; set; }
		public DbSet<ContactEntity> Contact { get; set; }
		public DbSet<TagEntity> Tag { get; set; }
		public DbSet<ReviewEntity> Reviews { get; set; }
	}
}
