using Microsoft.AspNetCore.Mvc;
using CarShopApi.Models;
using CarShopApi.Repository;
using CarShopApi.Dto;

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

    [HttpPost]
    public ActionResult<CarDto> AddCar([FromBody] CarDto car)
    {
      try
      {
        var carCreated = _repository.AddCar(car);
        return Ok(carCreated);
      }
      catch (Exception e)
      {
        return BadRequest(new { message = e.Message });
      }

    }


  }
}