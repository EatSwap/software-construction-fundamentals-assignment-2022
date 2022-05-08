namespace OrderManageCLI.database;

using Microsoft.EntityFrameworkCore;
using models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

public class OrderContext : DbContext {
	private const string serverInfo = "server=198.18.44.178;port=3306;database=CSHomework;user=root;password=123456";
	
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
		optionsBuilder.UseMySql(serverInfo, ServerVersion.Create(10, 5, 10, ServerType.MariaDb));
	}
	
	public DbSet<Customer> Customers { get; set; }
	
	public DbSet<Order> Orders { get; set; }
	
	public DbSet<Goods> Goods { get; set; }
	
	public DbSet<OrderDetails> OrderDetails { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder) {
		modelBuilder.Entity<Customer>().HasKey(e => e.Id);

		modelBuilder.Entity<Order>().HasKey(o => o.OrderId);

		modelBuilder.Entity<Goods>().HasKey(g => g.Id);

		modelBuilder.Entity<OrderDetails>().HasKey(od => od.Id);
	}
}