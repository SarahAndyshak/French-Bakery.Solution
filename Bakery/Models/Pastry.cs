namespace Bakery.Models
{
  public class Pastry
  {
    public int Pastry1 { get; set; }
    public Pastry(int donut1)
    {
      Pastry1 = donut1;
    }

    public int PastryOrderPrice()
    {
      if (Pastry1 >= 1)
      {
        return (Pastry1 * 2) - (Pastry1 / 4) * 2;
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