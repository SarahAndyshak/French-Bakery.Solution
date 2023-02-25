using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public static int Pastry1 { get; set; }
    public Pastry(int donut1)
    {
      Pastry1 = donut1;
    }

    public static int PastryOrderPrice()
    {
      if (Pastry1 >= 1)
      {
        return ((Pastry1 - (Pastry1 / 4)) * 2);
      }
      else
      {
        return -1;
      }
    }
    // public static int PastryOrderPrice()
    // {
    //   if(Pastry1 >= 1)
    //   {
    //     return Pastry1 * 2;
    //   }
    //   else
    //   {
    //     return -1;
    //   }
    // }
  }
}