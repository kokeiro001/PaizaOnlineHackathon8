using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class HatsukoiHair5Test : POHTest<HatsukoiHair5> {
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
