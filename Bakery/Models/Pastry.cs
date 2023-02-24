using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    private int _order;
    public int Order
    {
      get { return _order; }
      set { _order = value; }
    }

    public static int PastryOrderPrice(int order)
    {
      _order = order;
      if(order == 1)
      {
        return order * 2;
      }
      else
      {
        return -1;
      }
    }
  }
}