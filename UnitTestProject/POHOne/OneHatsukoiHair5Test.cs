using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class OneHatsukoiHair5Test : OnePOHTest<HatsukoiHair5_One> {
    [TestMethod]
    public void TestMethod1() {
      Input.AppendLine("10");
      Input.AppendLine("3");

      Expected.AppendLine("--+-------");
      Test();
    }

    [TestMethod]
    public void TestMethod2() {
      Input.AppendLine("20");
      Input.AppendLine("20");

      Expected.AppendLine("-------------------+");
      Test();
    }
  }
}
