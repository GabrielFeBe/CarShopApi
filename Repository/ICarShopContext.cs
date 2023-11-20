using Microsoft.EntityFrameworkCore;
using CarShopApi.Models;

namespace CarShopApi.Repository
{
  public interface ICarShopContext
  {
    public DbSet<Car> Cars { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public int SaveChanges();
  }
}