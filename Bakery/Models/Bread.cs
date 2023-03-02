using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Bread1 { get; set; }

    public Bread(int order1)
    {
      Bread1 = order1;
    }

    // public static int GetPrice()
    public int GetPrice()

    {
      if (Bread1 >= 1)
      {
          return (Bread1 * 5) - (Bread1 / 3) * 5;
      }
      else
      {
        return -1;
      }
    }

  }
}

//manually setting Bread1
// private int _bread1;
//     public int Bread1
//     {
//       get { return _bread1; }
//       set { _bread1 = value; }
//     }
//     public Bread(int order1)
//     {
//       _bread1 = order1;

//     }