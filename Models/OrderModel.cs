namespace CarShopApi.Models
{
  public class OrderModel
  {
    public int Id { get; set; }
    public int CarId { get; set; }
    public int UserId { get; set; }
    public string? OrderDate { get; set; }
    public string? OrderStatus { get; set; }
    public string? OrderTotal { get; set; }

    public CarModel? Car { get; set; }
    public UserModel? User { get; set; }
  }
}