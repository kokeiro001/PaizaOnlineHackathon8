using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class HatsukoiSpecial5Test : POHTest<HatsukoiSpecial5> {
    [TestMethod]
    public void TestMethod1() {
      Input.AppendLine("2");
      Input.AppendLine("9");
      Expected.AppendLine("3");
      Test();
    }

    [TestMethod]
    public void TestMethod2() {
      Input.AppendLine("1");
      Input.AppendLine("15");
      Expected.AppendLine("8");
      Test();
    }
  }
}
