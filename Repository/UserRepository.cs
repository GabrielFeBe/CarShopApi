using CarShopApi.Dto;
using CarShopApi.Models;
namespace CarShopApi.Repository
{

  public class UserRepository : IUserRepository
  {
    public readonly ICarShopContext _context;
    public UserRepository(ICarShopContext context)
    {
      _context = context;
    }

    public UserDto CreateUser(InsertUserDto user)
    {
      var EntityUser = new User
      {
        FirstName = user.FirstName,
        LastName = user.LastName,
        Email = user.Email,
        Password = user.Password,
        PhoneNumber = user.PhoneNumber,
        Address = user.Address,
        City = user.City,
        State = user.State,
        ZipCode = user.ZipCode,
        Country = user.Country,
        ImageUrl = user.ImageUrl
      };
      var testingEmail = _context.Users.FirstOrDefault(u => u.Email == user.Email);
      if (testingEmail == null)
      {

        var userCreated = _context.Users.Add(EntityUser);
        _context.SaveChanges();
        return new UserDto
        {
          UserId = userCreated.Entity.UserId,
          FirstName = userCreated.Entity.FirstName,
          LastName = userCreated.Entity.LastName,
          Email = userCreated.Entity.Email,
          PhoneNumber = userCreated.Entity.PhoneNumber,
          Address = userCreated.Entity.Address,
          City = userCreated.Entity.City,
          State = userCreated.Entity.State,
          ZipCode = userCreated.Entity.ZipCode,
          Country = userCreated.Entity.Country,
          ImageUrl = userCreated.Entity.ImageUrl
        };
      }
      else
      {
        throw new Exception("Email already exists");
      }
    }

    public void DeleteUser(int id)
    {
      throw new NotImplementedException();
    }

    public UserDto Login(LoginDto user)
    {
      var GetUser = GetUserByEmail(user.Email);
      if (GetUser.Password == user.Password)
      {
        return new UserDto
        {
          UserId = GetUser.UserId,
          FirstName = GetUser.FirstName,
          LastName = GetUser.LastName,
          Email = GetUser.Email,
          PhoneNumber = GetUser.PhoneNumber,
          Address = GetUser.Address,
          City = GetUser.City,
          State = GetUser.State,
          ZipCode = GetUser.ZipCode,
          Country = GetUser.Country,
          ImageUrl = GetUser.ImageUrl
        };

      }
      else
      {
        throw new Exception("Wrong password");
      }


    }

    public User GetUserByEmail(string email)
    {
      var user = _context.Users.FirstOrDefault(u => u.Email == email);
      if (user == null)
      {
        throw new Exception("User not found");
      }
      else
      {
        return user;
      }

    }

    public UserDto GetUserById(int id)
    {
      var user = _context.Users.FirstOrDefault(u => u.UserId == id);
      if (user == null)
      {
        throw new Exception("User not found");
      }
      else
      {
        return new UserDto
        {
          UserId = user.UserId,
          FirstName = user.FirstName,
          LastName = user.LastName,
          Email = user.Email,
          PhoneNumber = user.PhoneNumber,
          Address = user.Address,
          City = user.City,
          State = user.State,
          ZipCode = user.ZipCode,
          Country = user.Country,
          ImageUrl = user.ImageUrl
        };
      }
    }

    public UserDto UpdateUser(InsertUserDto user)
    {
      var GetUser = _context.Users.FirstOrDefault(u => u.Email == user.Email);
      if (GetUser == null)
      {
        throw new Exception("User not found");
      }
      else
      {
        GetUser.FirstName = user.FirstName;
        GetUser.LastName = user.LastName;
        GetUser.Email = user.Email;
        GetUser.Password = user.Password;
        GetUser.PhoneNumber = user.PhoneNumber;
        GetUser.Address = user.Address;
        GetUser.City = user.City;
        GetUser.State = user.State;
        GetUser.ZipCode = user.ZipCode;
        GetUser.Country = user.Country;
        GetUser.ImageUrl = user.ImageUrl;
        _context.SaveChanges();
        return new UserDto
        {
          UserId = GetUser.UserId,
          FirstName = GetUser.FirstName,
          LastName = GetUser.LastName,
          Email = GetUser.Email,
          PhoneNumber = GetUser.PhoneNumber,
          Address = GetUser.Address,
          City = GetUser.City,
          State = GetUser.State,
          ZipCode = GetUser.ZipCode,
          Country = GetUser.Country,
          ImageUrl = GetUser.ImageUrl
        };
      }
    }
  }

}