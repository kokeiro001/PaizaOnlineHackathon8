using NUnit.Framework;
using PaizaOnlineHackathon8;

namespace UnitTestProject {

  [TestFixture]
  public class HatsukoiClothes3Test : POHTest<HatsukoiClothes3> {

    [Test]
    public void TestMethod1() {
      Input.AppendLine("5 2");
      Expected.AppendLine("3");
      Test();
    }

    [Test]
    public void TestMethod2() {
      Input.AppendLine("10 10");
      Expected.AppendLine("0");
      Test();
    }

    [Test]
    public void TestMethod3() {
      Input.AppendLine("2 4");
      Expected.AppendLine("0");
      Test();
    }
  }

}
