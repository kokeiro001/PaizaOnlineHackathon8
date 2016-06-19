using NUnit.Framework;
using PaizaOnlineHackathon8;

namespace UnitTestProject {

  [TestFixture]
  public class OneHatsukoiEye3Test :OnePOHTest<HatsukoiEye3_One> {

    [Test]
    public void TestMethod1() {
      Input.AppendLine("850");
      Expected.AppendLine("8");
      Test();
    }

    [Test]
    public void TestMethod2() {
      Input.AppendLine("1230");
      Expected.AppendLine("22");
      Test();
    }
  }
}
