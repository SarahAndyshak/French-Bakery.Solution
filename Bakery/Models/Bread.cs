using System;
using System.Collections.Generic;

namespace Bakery.Models
{

  public class Bread
  {
    public int Bread1 { get; set; }
    // private int _bread1;
    // public int Bread1
    // {
    //   get { return _bread1; }
    //   set { _bread1 = value; }
    // }
    public Bread(int order1)
    {
      // _bread1 = order1;
      Bread1 = order1;

    }

  }
}

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