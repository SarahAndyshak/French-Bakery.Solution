using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadOrder_ReturnsPriceForBread_Int()
    {
      int order1 = 1;
      Bread newBread = new Bread(order1);
      int result = newBread.OrderBread;
      Assert.AreEqual(order1, result);
    }
  }
}