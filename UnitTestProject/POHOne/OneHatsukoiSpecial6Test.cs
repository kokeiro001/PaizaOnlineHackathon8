using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class OneHatsukoiSpecial6Test : OnePOHTest<HatsukoiSpecial6_One> {
    [TestMethod]
    public void TestMethod1() {
      Input.AppendLine("100 110");
      Input.AppendLine("20 200");

      Expected.AppendLine("12000");
      Test();
    }

    [TestMethod]
    public void TestMethod2() {
      Input.AppendLine("980 200");
      Input.AppendLine("200 1000");

      Expected.AppendLine("201000");
      Test();
    }
  }
}
