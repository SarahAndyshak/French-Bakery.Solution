using System;
using System.Collections.Generic;

namespace Bakery.Models
{

  public class Bread
  {
    private int _bread1;
    public int Bread1
    {
      get { return _bread1; }
    }
    public Bread(int order1)
    {
      _bread1 = order1;
      
    }

  }
}