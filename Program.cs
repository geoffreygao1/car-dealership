using System;
using System.Linq;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, 150);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, 80);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, 90);
      Car amc = new Car("1976 AMC Pacer", 400, 198000, 200);
      Motorcycle kawasaki = new Motorcycle("ninja", 400, 198000);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

      // Console.WriteLine(yugo.MakeModel);
      // yugo.MakeModel = "Worst Car Ever";
      // Console.WriteLine(yugo.MakeModel);

      // Console.WriteLine("Enter maximum price: ");
      // string stringMaxPrice = Console.ReadLine();
      // int maxPrice = int.Parse(stringMaxPrice);

      // List<Car> CarsMatchingSearch = new List<Car>(0);

      // foreach (Car automobile in Cars)
      // {
      //   if (automobile.WorthBuying(maxPrice))
      //   {
      //     CarsMatchingSearch.Add(automobile);
      //   }
      // }

      // foreach (Car automobile in CarsMatchingSearch)
      // {
      //   Console.WriteLine("----------------------");
      //   Console.WriteLine(automobile.MakeModel);
      //   Console.WriteLine(automobile.Miles + " miles");
      //   Console.WriteLine("$" + automobile.Price);
      // }

      // Console.WriteLine("Enter percentage to lower price");
      // string stringPercentage = Console.ReadLine();
      // int percentage = int.Parse(stringPercentage);

      // foreach (Car automobile in Cars)
      // {
      //   automobile.LowerPrice(percentage);
      //   Console.WriteLine("The sales price of " + automobile.MakeModel + "is " + automobile.Price);
      // }

      Dictionary<string, int> topSpeed = new Dictionary<string, int>() { };

      foreach (Car automobile in Cars)
      {
        topSpeed[automobile.MakeModel] = automobile.TopSpeed;
      }

      var ordered = topSpeed.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

      foreach (KeyValuePair<string, int> x in ordered)
      {
        Console.WriteLine("The car " + x.Key + " has a max speed of " + x.Value);
      }
    }
  }
}
