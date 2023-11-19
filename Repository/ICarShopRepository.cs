using CarShopApi.Models;

namespace CarShopApi.Repository
{

  public interface ICarRepository
  {
    List<CarModel> GetAllCars();
    // CarModel GetCarById(int id);
    // CarModel GetCarByModel(string model);
    // void AddCar(CarModel car);
    // void UpdateCar(CarModel car);
    // void DeleteCar(CarModel car);
  }
}