namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public double Price { get; set; }
    public int Miles { get; set; }

    public int TopSpeed { get; set; }

    public Car(string makeModel, int price, int miles, int topSpeed)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      TopSpeed = topSpeed;
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public void LowerPrice(double percent)
    {
      Price = Price * (1 - (percent / 100));
    }
  }
}

