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
      Pastry testPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }

    [TestMethod] // tests for price, need order to be able to change in Pastry.cs, may need constructor?
    public void PastryOrderPrice_ReturnsPriceForOrder_Int()
    {
      int input = 1;
      int result = Pastry.PastryOrderPrice(input);
      Assert.AreEqual(2, result);
    }
  }
}