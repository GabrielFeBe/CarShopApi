using CarShopApi.Dto;
using CarShopApi.Models;
namespace CarShopApi.Repository
{
  public interface IOrderRepository
  {
    List<OrderDto> GetAllOrders();
    Order GetOrderById(int id);
    void AddOrder(Order order);
    void UpdateOrder(Order order);
    void DeleteOrder(Order order);
  }
}