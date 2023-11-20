using CarShopApi.Dto;
using CarShopApi.Models;

namespace CarShopApi.Repository
{

  public interface ICarRepository
  {
    List<Car> GetAllCars();
    CarDto AddCar(CarDto car);
  }
}