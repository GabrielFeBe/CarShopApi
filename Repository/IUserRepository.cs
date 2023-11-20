using CarShopApi.Dto;
using CarShopApi.Models;
namespace CarShopApi.Repository
{
  public interface IUserRepository
  {
    UserDto GetUserById(int id);
    UserDto GetUserByEmail(string email);
    UserDto CreateUser(InsertUserDto user);
    UserDto UpdateUser(InsertUserDto user);
    void DeleteUser(int id);
  }

}