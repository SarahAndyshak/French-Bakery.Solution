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
      int order1 = 1;
      Bread newBread = new Bread(order1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void Bread_ReturnsOrderForBread_Int()
    {
      int order1 = 1;
      Bread newBread = new Bread(order1);
      int result = newBread.Bread1;
      Assert.AreEqual(order1, result);
    }


  }
}