using CarShopApi.Dto;
using CarShopApi.Models;
namespace CarShopApi.Repository
{
  public interface IUserRepository
  {
    UserDto GetUserById(int id);
    User GetUserByEmail(string email);
    UserDto CreateUser(InsertUserDto user);
    UserDto UpdateUser(InsertUserDto user);
    UserDto Login(LoginDto user);

    void DeleteUser(int id);
  }

}