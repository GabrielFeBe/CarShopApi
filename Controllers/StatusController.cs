using Microsoft.AspNetCore.Mvc;


namespace TrybeHotel.Controllers
{
  [ApiController]
  [Route("/")]
  public class StatusController : Controller
  {
    [HttpGet]
    public IActionResult GetStatus()
    {
      var online = new
      {
        message = "online"
      };

      return Ok(online);
    }
  }
}
