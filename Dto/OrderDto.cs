namespace CarShopApi.Dto
{


  public class InsertOrderDto
  {
    public int UserId { get; set; }
    public int CarId { get; set; }
    public DateTime OrderDate { get; set; }
    public string? OrderStatus { get; set; }

  }
  public class OrderDto
  {

    public DateTime OrderDate { get; set; }
    public string? OrderStatus { get; set; }
    public int? OrderTotal { get; set; }
    public UserDto User { get; set; }

    public CarDto Car { get; set; }
  }


}