using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitterApp;

namespace UnitTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void BabysitterStartsNoEarlierThan1700()
    {
      BabySitter bs = new BabySitter();
      Assert.AreEqual("Too Early", bs.PayForWorkFromTo(1600, 400));
    }
  }
}
