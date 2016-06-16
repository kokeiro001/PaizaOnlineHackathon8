using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class OneHatsukoiEye2Test : OnePOHTest<HatsukoiEye2_One> {
    [TestMethod]
    public void TestMethod1() {
      Input.AppendLine("5 2");
      Expected.AppendLine("OK");
      Test();
    }

    [TestMethod]
    public void TestMethod2() {
      Input.AppendLine("3 4");
      Expected.AppendLine("NG");
      Test();
    }
  }
}
