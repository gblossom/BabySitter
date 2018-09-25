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

    [TestMethod]
    public void BabysitterOnlyWorksOneHourDuringBedtime()
    {
      BabySitter bs = new BabySitter();
      Assert.AreEqual("8", bs.PayForWorkFromTo(2100, 2200));
    }

    [TestMethod]
    public void BabysitterOnlyWorksOneHourAfterMidnight()
    {
      BabySitter bs = new BabySitter();
      Assert.AreEqual("16", bs.PayForWorkFromTo(0, 100));
    }

    [TestMethod]
    public void BabysitterOnlyWorksAllAllowedHours()
    {
      BabySitter bs = new BabySitter();
      Assert.AreEqual("136", bs.PayForWorkFromTo(1700, 400));
    }

    [TestMethod]
    public void BabysitterOnlyWorksOnePartialHourBeforeBedtime()
    {
      BabySitter bs = new BabySitter();
      Assert.AreEqual("12", bs.PayForWorkFromTo(1720, 1800));
    }
  }
}
