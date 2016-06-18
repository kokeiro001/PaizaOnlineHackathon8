using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class OneHatsukoiSpecial2Test :OnePOHTest<HatsukoiSpecial2_One> {
    [TestMethod]
    public void TestMethod1() {
      Input.AppendLine("5 5");
      Input.AppendLine("paiza");
      Input.AppendLine("pizza");
      Expected.AppendLine("1");
      Test();
    }

    [TestMethod]
    public void TestMethod2() {
      Input.AppendLine("3 5");
      Input.AppendLine("ant");
      Input.AppendLine("maven");
      Expected.AppendLine("3");
      Test();
    }

    [TestMethod]
    public void TestMethod3() {
      Input.AppendLine("3 3");
      Input.AppendLine("aaa");
      Input.AppendLine("bbb");
      Expected.AppendLine("3");
      Test();
    }

    [TestMethod]
    public void TestMethod4() {
      Input.AppendLine("3 3");
      Input.AppendLine("aaa");
      Input.AppendLine("aaa");
      Expected.AppendLine("0");
      Test();
    }

    [TestMethod]
    public void TestMethod5() {
      Input.AppendLine("3 3");
      Input.AppendLine("aaa");
      Input.AppendLine("aaabbbccc");
      Expected.AppendLine("6");
      Test();
    }
  }
}
