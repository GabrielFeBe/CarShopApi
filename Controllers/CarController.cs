using Microsoft.AspNetCore.Mvc;
using CarShopApi.Models;
using CarShopApi.Repository;

namespace TrybeHotel.Controllers
{
  [ApiController]
  [Route("booking")]
  public class BookingController : Controller
  {
    private readonly ICarRepository _repository;
    public BookingController(ICarRepository repository)
    {
      _repository = repository;
    }

    [HttpGet]
    public ActionResult<List<CarModel>> GetAllCars()
    {
      return _repository.GetAllCars();
    }



  }
}