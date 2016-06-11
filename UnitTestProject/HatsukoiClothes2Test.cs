using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class HatsukoiClothes2Test : POHTest<HatsukoiClothes2> {
    [TestMethod]
    public void TestMethod1() {
      Input.AppendLine("3 6");
      Expected.AppendLine("ok");
      Test();
    }

    [TestMethod]
    public void TestMethod2() {
      Input.AppendLine("2 7");
      Expected.AppendLine("ng");
      Test();
    }
  }
}
