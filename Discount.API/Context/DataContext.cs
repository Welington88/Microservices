using Microsoft.EntityFrameworkCore;
using Discount.API.Entities;

namespace Discount.API.Context
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}

		public DbSet<Coupon>? Coupon { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Coupon>().HasKey(p => p.Id);
			base.OnModelCreating(modelBuilder);
        }
    }
}

