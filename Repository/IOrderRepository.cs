using CarShopApi.Dto;
using CarShopApi.Models;
namespace CarShopApi.Repository
{
  public interface IOrderRepository
  {
    List<OrderDto> GetAllOrders();
    Order GetOrderById(int id);
    OrderDto AddOrder(InsertOrderDto order);
    void UpdateOrder(Order order);
    void DeleteOrder(Order order);
  }
}