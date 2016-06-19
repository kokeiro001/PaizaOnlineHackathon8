using NUnit.Framework;
using PaizaOnlineHackathon8;

namespace UnitTestProject {

  [TestFixture]
  public class OneHatsukoiEye4Test : OnePOHTest<HatsukoiEye4_One> {

    [Test]
    public void TestMethod1() {
      Input.AppendLine("5");
      Input.AppendLine("2 3 5 4 1");
      Expected.AppendLine("3");
      Test();
    }

    [Test]
    public void TestMethod2() {
      Input.AppendLine("7");
      Input.AppendLine("27 100 83 2 57 71 40");
      Expected.AppendLine("57");
      Test();
    }
  }
}
