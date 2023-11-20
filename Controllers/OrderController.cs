using Microsoft.AspNetCore.Mvc;
using CarShopApi.Models;
using CarShopApi.Repository;
using CarShopApi.Dto;

namespace TrybeHotel.Controllers
{
  [ApiController]
  [Route("order")]
  public class OrderController : Controller
  {
    private readonly IOrderRepository _repository;
    public OrderController(IOrderRepository repository)
    {
      _repository = repository;
    }

    [HttpGet]
    public ActionResult<List<OrderDto>> GetAllOrders()
    {
      var orders = _repository.GetAllOrders();
      return Ok(orders);
    }



  }
}