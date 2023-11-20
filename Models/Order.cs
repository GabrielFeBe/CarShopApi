using System.ComponentModel.DataAnnotations.Schema;

namespace CarShopApi.Models
{
  public class Order
  {
    public int Id { get; set; }
    [ForeignKey("CarId")]
    public int CarId { get; set; }
    [ForeignKey("UserId")]
    public int UserId { get; set; }
    public string? OrderDate { get; set; }
    public string? OrderStatus { get; set; }
    public string? OrderTotal { get; set; }

    public Car? Car { get; set; }
    public User? User { get; set; }
  }
}