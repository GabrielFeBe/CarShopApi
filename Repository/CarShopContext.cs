using Microsoft.EntityFrameworkCore;
using CarShopApi.Models;

namespace CarShopApi.Repository
{
  public class CarShopContext : DbContext, ICarShopContext
  {
    public DbSet<CarModel> Cars { get; set; }
    public CarShopContext(DbContextOptions<CarShopContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        var connectionString = "Server=localhost;User Id=root;Password=123456;Port=3306;Database=ContactDB;";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), null);
      }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder) { }

  }
}