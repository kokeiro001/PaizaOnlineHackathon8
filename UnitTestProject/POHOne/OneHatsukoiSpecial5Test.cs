using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class OneHatsukoiSpecial5Test : OnePOHTest<HatsukoiSpecial5_One> {
    [TestMethod]
    public void TestMethod1() {
      Input.AppendLine("2");
      Input.AppendLine("9");
      Expected.AppendLine("3");
      Test();
    }

    [TestMethod]
    public void TestMethod2() {
      Input.AppendLine("1");
      Input.AppendLine("15");
      Expected.AppendLine("8");
      Test();
    }

    [TestMethod]
    public void TestMethod3() {
      Input.AppendLine("2");
      Input.AppendLine("4");
      Expected.AppendLine("1");
      Test();
    }

    [TestMethod]
    public void TestMethod4() {
      Input.AppendLine("2");
      Input.AppendLine("8");
      Expected.AppendLine("2");
      Test();
    }
  }
}
