namespace CarShopApi.Dto
{
  public class InsertOrderDto
  {
    public int UserId { get; set; }
    public int CarId { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime DeliveryDate { get; set; }
    public string Status { get; set; }
    public string Comments { get; set; }
  }
  public class OrderDto
  {
    public string? OrderDate { get; set; }
    public string? OrderStatus { get; set; }
    public string? OrderTotal { get; set; }
    public UserDto User { get; set; }

    public CarDto Car { get; set; }
  }


}