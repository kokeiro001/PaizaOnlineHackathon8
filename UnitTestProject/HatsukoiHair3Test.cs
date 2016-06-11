using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class HatsukoiHair3Test : POHTest<HatsukoiHair3> {

    [TestMethod]
    public void TestMethod1() {
      Input.AppendLine("7");
      Expected.AppendLine("lucky");
      Test();
    }
    [TestMethod]
    public void TestMethod2() {
      Input.AppendLine("12");
      Expected.AppendLine("unlucky");
      Test();
    }
  }
}
