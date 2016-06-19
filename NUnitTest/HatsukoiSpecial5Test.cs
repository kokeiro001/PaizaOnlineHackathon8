using NUnit.Framework;
using PaizaOnlineHackathon8;

namespace UnitTestProject {

  [TestFixture]
  public class HatsukoiSpecial5Test : POHTest<HatsukoiSpecial5> {

    [Test]
    public void TestMethod1() {
      Input.AppendLine("2");
      Input.AppendLine("9");
      Expected.AppendLine("3");
      Test();
    }

    [Test]
    public void TestMethod2() {
      Input.AppendLine("1");
      Input.AppendLine("15");
      Expected.AppendLine("8");
      Test();
    }
  }
}
