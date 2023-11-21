using CarShopApi.Models;
using CarShopApi.Dto;
using Microsoft.EntityFrameworkCore;

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
      // if you want to return the cars with their orders, use this:
      // return _context.Cars.Include(c => c.Orders).ThenInclude(o => o.User).ToList();
      // but i'll be leaving it returning just the cars for now
      return _context.Cars.ToList();
    }
  }



}