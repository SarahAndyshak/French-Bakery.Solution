using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBreadOrder_BreadOrder()
    {
      BreadOrder newBread = new BreadOrder();
      Assert.AreEqual(typeof(BreadOrder), newBread.GetType());
    }
  }
}