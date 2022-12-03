using Microsoft.EntityFrameworkCore;

namespace Data_Base
{
	public class HelloappdbContext : DbContext
	{
		public HelloappdbContext()
		{
			Database.EnsureDeleted();
			Database.EnsureCreated();
		}
        public DbSet<LoggingClasses> LoggningClassess { get; set; }

        public DbSet<Company> Companies { get; set; }

		public DbSet<CustomerProfile> CustomerProfiles { get; set; }

		public DbSet<Delivery> Deliveries { get; set; }

		public DbSet<FeedBack> FeedBacks { get; set; }

		public DbSet<Order> Orders { get; set; }

		public DbSet<PackageList> PackageLists { get; set; }

		public DbSet<Product> Products { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=helloappdb;Trusted_Connection=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CustomerProfile>(entity =>
			{

				entity.HasOne(d => d.IdNavigation)
				.WithOne(p => p.CustomerProfile)
				.HasForeignKey<CustomerProfile>(d => d.Id);
			});

			modelBuilder.Entity<Delivery>(entity =>
			{
				entity.HasOne(d => d.IdNavigation)
				.WithOne(p => p.Delivery)
				.HasForeignKey<Delivery>(d => d.Id);
			});

			modelBuilder.Entity<FeedBack>(entity =>
			{
				entity.HasOne(d => d.IdNavigation)
				.WithOne(p => p.FeedBack)
				.HasForeignKey<FeedBack>(d => d.Id);
			});

			modelBuilder.Entity<Order>(entity =>
			{
				entity.HasOne(d => d.IdNavigation).WithOne(p => p.Order)
					.HasForeignKey<Order>(d => d.Id);
			});

			modelBuilder.Entity<PackageList>(entity =>
			{


				entity.HasOne(d => d.IdNavigation).WithOne(p => p.PackageList)
					.HasForeignKey<PackageList>(d => d.Id);
			});

			modelBuilder.Entity<Product>(entity =>
			{
				entity.HasOne(d => d.IdNavigation).WithOne(p => p.Product)
					.HasForeignKey<Product>(d => d.Id);

				entity.HasMany(d => d.Id1).WithOne(p => p.Product)
					.HasForeignKey(d => d.ProductId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Products_Orders");
			});
		}
	}
}