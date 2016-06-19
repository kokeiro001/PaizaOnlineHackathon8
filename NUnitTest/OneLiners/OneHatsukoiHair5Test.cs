using NUnit.Framework;
using PaizaOnlineHackathon8;

namespace UnitTestProject {

  [TestFixture]
  public class OneHatsukoiHair5Test : OnePOHTest<HatsukoiHair5_One> {

    [Test]
    public void TestMethod1() {
      Input.AppendLine("10");
      Input.AppendLine("3");

      Expected.AppendLine("--+-------");
      Test();
    }

    [Test]
    public void TestMethod2() {
      Input.AppendLine("20");
      Input.AppendLine("20");

      Expected.AppendLine("-------------------+");
      Test();
    }
  }
}
