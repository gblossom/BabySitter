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
      Assert.AreEqual("Too Early", bs.PayForWorkFromTo(1659, 400));
    }

    [TestMethod]
    public void BabysitterWorksNoLaterThan0400()
    {
      BabySitter bs = new BabySitter();
      Assert.AreEqual("Too Late", bs.PayForWorkFromTo(1700, 401));
    }

    [TestMethod]
    public void BabysitterOnlyWorksOneHourBeforeBedtime()
    {
      BabySitter bs = new BabySitter();
      Assert.AreEqual("12", bs.PayForWorkFromTo(1700, 1800));
    }
  }
}
