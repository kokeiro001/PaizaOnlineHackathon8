using NUnit.Framework;
using PaizaOnlineHackathon8;

namespace UnitTestProject {

  [TestFixture]
  public class HatsukoiSpecial2Test :POHTest<HatsukoiSpecial2> {

    [Test]
    public void TestMethod1() {
      Input.AppendLine("5 5");
      Input.AppendLine("paiza");
      Input.AppendLine("pizza");
      Expected.AppendLine("1");
      Test();
    }

    [Test]
    public void TestMethod2() {
      Input.AppendLine("3 5");
      Input.AppendLine("ant");
      Input.AppendLine("maven");
      Expected.AppendLine("3");
      Test();
    }

    [Test]
    public void TestMethod3() {
      Input.AppendLine("3 3");
      Input.AppendLine("aaa");
      Input.AppendLine("bbb");
      Expected.AppendLine("3");
      Test();
    }

    [Test]
    public void TestMethod4() {
      Input.AppendLine("3 3");
      Input.AppendLine("aaa");
      Input.AppendLine("aaa");
      Expected.AppendLine("0");
      Test();
    }
  }
}
