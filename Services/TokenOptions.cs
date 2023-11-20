namespace CarShopApi.Services
{
  public class TokenOptions
  {
    public const string Token = "Token";
    public string Secret { get; set; }
    public int ExpiresDays { get; set; }
  }


}