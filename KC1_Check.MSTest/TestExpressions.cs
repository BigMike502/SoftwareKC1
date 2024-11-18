using KnowledgeCheck1_Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KC1_Check.MSTest
{
  [TestClass]
  public class TestExpressions
  {
    [TestMethod]
    public void TestNumberVal()
    {
      bool testNumber;

      testNumber = CheckExpressions.IsInputANumber("4");

      Assert.IsTrue(testNumber);
    }
  }
}
