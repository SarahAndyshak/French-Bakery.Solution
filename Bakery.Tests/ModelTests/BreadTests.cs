using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod] // checks existence of constructor
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      int order1 = 1;
      Bread newBread = new Bread(order1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod] // checks that order1 input matches Bread1 created Bread object
    public void Bread_ReturnsOrderForBread_Int()
    {
      int order1 = 1;
      Bread newBread = new Bread(order1);
      int result = newBread.Bread1;
      Assert.AreEqual(order1, result);
    }

    [TestMethod] // checks price for Bread1 objects created by order1
    public void Bread_ReturnsPriceForOrder_Int()
    {
      int order1 = 1; 
      Bread newBread = new Bread(order1);
      int result = newBread.GetPrice();
      Assert.AreEqual(5, result);
    }
  }
}