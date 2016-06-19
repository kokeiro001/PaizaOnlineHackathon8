using NUnit.Framework;
using PaizaOnlineHackathon8;

namespace UnitTestProject {

  [TestFixture]
  public class HatsukoiHair2Test : POHTest<HatsukoiHair2> {

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
