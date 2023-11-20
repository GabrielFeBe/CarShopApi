using Microsoft.AspNetCore.Mvc;
using CarShopApi.Models;
using CarShopApi.Repository;

namespace TrybeHotel.Controllers
{
  [ApiController]
  [Route("car")]
  public class CarController : Controller
  {
    private readonly ICarRepository _repository;
    public CarController(ICarRepository repository)
    {
      _repository = repository;
    }

    [HttpGet]
    public ActionResult<List<Car>> GetAllCars()
    {
      return _repository.GetAllCars();
    }



  }
}