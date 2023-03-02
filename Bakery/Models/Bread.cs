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