using CarShopApi.Models;
using CarShopApi.Dto;

namespace CarShopApi.Repository
{

  public class CarRepository : ICarRepository
  {
    protected readonly ICarShopContext _context;
    public CarRepository(ICarShopContext context)
    {
      _context = context;
    }

    public CarDto AddCar(CarDto car)
    {
      var newCar = new Car

      {
        Model = car.Model,
        Year = car.Year,
        Color = car.Color,
        Price = car.Price,
        Description = car.Description,
        Make = car.Make,
        BodyStyle = car.BodyStyle,
        Condition = car.Condition,
        DriveTrain = car.DriveTrain,
        FuelType = car.FuelType,
        ImageUrl = car.ImageUrl,
        Transmission = car.Transmission
      };
      _context.Cars.Add(newCar);
      _context.SaveChanges();
      return car;

    }

    public List<Car> GetAllCars()
    {
      return _context.Cars.ToList();
    }
  }



}