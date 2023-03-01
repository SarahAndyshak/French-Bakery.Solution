using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreatesInstanceOfPastry_Pastry()
    {
      int donut1 = 1;
      Pastry testPastry = new Pastry(donut1);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }

    // [TestMethod] // tests for price, need order to be able to change in Pastry.cs, may need constructor?
    // public void PastryOrderPrice_ReturnsPriceForOrder_Int()
    // {
    //   Pastry newPastry = new PastryTests(1);
    //   // int input = 1;
    //   int result = Pastry.PastryOrderPrice();
    //   Assert.AreEqual(2, result);
    // }

    // [TestMethod] // checks that donut1 input matches Pastry1 created Pastry object
    //   public void Pastry_ReturnsOrderForPastry_Int()
    // {
    //   int donut1 = 1;
    //   Pastry newPastry = new Pastry(donut1);
    //   int result = Pastry.Pastry1;
    //   Assert.AreEqual(donut1, result);
    // }

    // [TestMethod] // check price for larger order
    // public void Pastry_ReturnsForLargerOrder_Int()
    // {
    //   // int input = 6;
    //   Pastry newPastry = new PastryTests(1);
    //   int result = Pastry.PastryOrderPrice();
    //   Assert.AreEqual(12, result);
    // }

    [TestMethod] // check price for a larger amount of pastry
    public void Pastry_PastryOrderPrice_Int()
    {
      Pastry newPastry = new Pastry(6);
      int result = Pastry.PastryOrderPrice(); 
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void Pastry_DiscountedPrice_Int()
    {
      Pastry newPastry = new Pastry(7);
      int result = Pastry.PastryOrderPrice();
      Assert.AreEqual(12, result);
    }

    // [TestMethod]
    // public void
    // Pastry_UpdatedDiscountMath_Int()
    // {
    //   Pastry newPastry = new Pastry(7);
    //   int result = Pastry.PastryOrderPrice();
    //   Assert.AreEqual(12, result);
    // }
  }
}