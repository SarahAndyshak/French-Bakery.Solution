using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to Pierre's French Bakery!");
      Console.WriteLine("Each loaf of bread costs $5, but today's deal is buy 2, get 1 free!");
      Console.WriteLine("How many loaves of bread would you like?");
      string stringNumber1 = Console.ReadLine();
      Console.WriteLine("Each pastry costs $2, but today they are on sale for buy 3, get 1 free!");
      Console.WriteLine("How many pastries would you like?");
      string stringNumber2 = Console.ReadLine();
      // code to calculate bread price + pastry price
      int breadOrder = int.Parse(stringNumber1);
      int pastryOrder = int.Parse(stringNumber2);
      Bread newBread = new Bread(breadOrder);
      Pastry newPastry = new Pastry(pastryOrder);
      int result1 = newBread.GetPrice();
      int result2 = newPastry.PastryOrderPrice();
      int finalTotal = result1 + result2;
      Console.WriteLine($"Your total comes to ${finalTotal}. Thank you!");
    }
  }
}