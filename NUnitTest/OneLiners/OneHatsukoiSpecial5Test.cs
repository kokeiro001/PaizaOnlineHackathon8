using NUnit.Framework;
using PaizaOnlineHackathon8;

namespace UnitTestProject {

  [TestFixture]
  public class OneHatsukoiSpecial5Test : OnePOHTest<HatsukoiSpecial5_One> {

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

    [Test]
    public void TestMethod3() {
      Input.AppendLine("2");
      Input.AppendLine("4");
      Expected.AppendLine("1");
      Test();
    }

    [Test]
    public void TestMethod4() {
      Input.AppendLine("2");
      Input.AppendLine("8");
      Expected.AppendLine("2");
      Test();
    }
  }
}
