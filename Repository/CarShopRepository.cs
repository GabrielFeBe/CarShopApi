using CarShopApi.Models;

namespace CarShopApi.Repository
{

  public class CarRepository : ICarRepository
  {
    protected readonly ICarShopContext _context;
    public CarRepository(ICarShopContext context)
    {
      _context = context;
    }
    public List<Car> GetAllCars()
    {
      return _context.Cars.ToList();
    }
  }

}