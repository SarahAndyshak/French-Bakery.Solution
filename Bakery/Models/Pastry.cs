using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    // private int _pastryOrder = 0;
    // public int PastryOrder { get; set;}
    public static int PastryOrderPrice(int order)
    {
      if(order == 1)
      {
        return 4;
      }
      else
      {
        return -1;
      }
    }
  }
}