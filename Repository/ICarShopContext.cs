using Microsoft.EntityFrameworkCore;
using CarShopApi.Models;

namespace CarShopApi.Repository
{
  public interface ICarShopContext
  {
    public DbSet<CarModel> Cars { get; set; }
    public int SaveChanges();
  }
}