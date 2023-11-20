using CarShopApi.Dto;
using CarShopApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShopApi.Repository
{
  public class OrderRepository : IOrderRepository
  {
    public ICarShopContext _context { get; set; }
    public OrderRepository(ICarShopContext context)
    {
      _context = context;
    }

    public List<OrderDto> GetAllOrders()
    {
      var orders = _context.Orders.Include(o => o.Car).Include(o => o.User).ToList();

      var orderDtos = from order in orders
                      select new OrderDto
                      {
                        OrderDate = order.OrderDate,
                        OrderStatus = order.OrderStatus,
                        OrderTotal = order.OrderTotal,
                        Car = new CarDto
                        {
                          Make = order.Car.Make,
                          Model = order.Car.Model,
                          Year = order.Car.Year,
                          Price = order.Car.Price,
                          Description = order.Car.Description,
                          BodyStyle = order.Car.BodyStyle,
                          Color = order.Car.Color,
                          Condition = order.Car.Condition,
                          DriveTrain = order.Car.DriveTrain,
                          FuelType = order.Car.FuelType,
                          ImageUrl = order.Car.ImageUrl,
                          Transmission = order.Car.Transmission
                        },
                        User = new UserDto
                        {
                          FirstName = order.User.FirstName,
                          LastName = order.User.LastName,
                          Email = order.User.Email,
                          PhoneNumber = order.User.PhoneNumber,
                          Address = order.User.Address,
                          City = order.User.City,
                          State = order.User.State,
                          ZipCode = order.User.ZipCode

                        }
                      };


      return orderDtos.ToList();
    }

    public Order GetOrderById(int id)
    {
      throw new NotImplementedException();
    }

    public void AddOrder(Order order)
    {
      throw new NotImplementedException();
    }

    public void UpdateOrder(Order order)
    {
      throw new NotImplementedException();
    }

    public void DeleteOrder(Order order)
    {
      throw new NotImplementedException();
    }
  }
}