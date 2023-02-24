using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int OrderBread { get; set; }
    public Bread(int order1)
    {
      OrderBread = order1;
    }

  }
}

// commit .gitignore first
// run dotnet restore to install all .csproj auto-created files -- obj directories in production and test projects