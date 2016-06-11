using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class HatsukoiSpecial2Test :POHTest<HatsukoiSpecial2> {
    [TestMethod]
    public void TestMethod1() {
      Input.AppendLine("5 5");
      Input.AppendLine("paiza");
      Input.AppendLine("pizza");
      Expected.AppendLine("1");
      Test();
    }

    [TestMethod]
    public void TestMethod2() {
      Input.AppendLine("3 5");
      Input.AppendLine("ant");
      Input.AppendLine("maven");
      Expected.AppendLine("3");
      Test();
    }
  }
}
