using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;

namespace ProjectName.Tests
{
  [TestClass]
  public class ClassNameTests
  // public class ClassNameTests : IDisposable -- use if need to clear out previous results
  // {
  //   public void Dispose()
  //   {
  //     // Code inside this method is run between each test.
  //   }
  {
    // Test methods go here
    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // we can also use the arrange, act, assert organization in any test. 
      Assert.AreEqual(ExpectedResult, CodeToTest);
    }
  }
}

// set up with dotnet restore in ProjectName.Tests directory
// run tests with dotnet test