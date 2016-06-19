using NUnit.Framework;
using PaizaOnlineHackathon8;

namespace UnitTestProject {

  [TestFixture]
  public class OneHatsukoiHair2Test : OnePOHTest<HatsukoiHair2_One> {

    [Test]
    public void TestMethod1() {
      Input.AppendLine("3");
      Input.AppendLine("idol");

      Expected.AppendLine("idol");
      Expected.AppendLine("idol");
      Expected.AppendLine("idol");

      Test();
    }

    [Test]
    public void TestMethod2() {
      Input.AppendLine("10");
      Input.AppendLine("dream");

      Expected.AppendLine("dream");
      Expected.AppendLine("dream");
      Expected.AppendLine("dream");
      Expected.AppendLine("dream");
      Expected.AppendLine("dream");
      Expected.AppendLine("dream");
      Expected.AppendLine("dream");
      Expected.AppendLine("dream");
      Expected.AppendLine("dream");
      Expected.AppendLine("dream");
      Test();
    }
  }
}
