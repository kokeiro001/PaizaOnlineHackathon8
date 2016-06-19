using NUnit.Framework;
using PaizaOnlineHackathon8;

namespace UnitTestProject {

  [TestFixture]
  public class HatsukoiClothes2Test : POHTest<HatsukoiClothes2> {

    [Test]
    public void TestMethod1() {
      Input.AppendLine("3 6");
      Expected.AppendLine("ok");
      Test();
    }

    [Test]
    public void TestMethod2() {
      Input.AppendLine("2 7");
      Expected.AppendLine("ng");
      Test();
    }
  }
}
