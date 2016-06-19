using NUnit.Framework;
using PaizaOnlineHackathon8;

namespace UnitTestProject {

  [TestFixture]
  public class HatsukoiEye2Test : POHTest<HatsukoiEye2> {

    [Test]
    public void TestMethod1() {
      Input.AppendLine("5 2");
      Expected.AppendLine("OK");
      Test();
    }

    [Test]
    public void TestMethod2() {
      Input.AppendLine("3 4");
      Expected.AppendLine("NG");
      Test();
    }
  }
}
