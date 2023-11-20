using Microsoft.AspNetCore.Mvc;
using CarShopApi.Models;
using CarShopApi.Repository;
using CarShopApi.Dto;

namespace TrybeHotel.Controllers
{
  [ApiController]
  [Route("user")]
  public class UserController : Controller
  {
    private readonly IUserRepository _repository;
    public UserController(IUserRepository repository)
    {
      _repository = repository;
    }

    [HttpPost("create")]
    public ActionResult<UserDto> CreateUser([FromBody] InsertUserDto user)
    {
      try
      {
        var userCreated = _repository.CreateUser(user);
        return Ok(userCreated);
      }
      catch (Exception e)
      {
        return BadRequest(new { message = e.Message });
      }

    }

    [HttpPut("update")]
    public ActionResult<UserDto> UpdateUser([FromBody] InsertUserDto user)
    {
      try
      {
        var userUpdated = _repository.UpdateUser(user);
        return Ok(userUpdated);
      }
      catch (Exception e)
      {
        return BadRequest(new { message = e.Message });
      }

    }



  }
}