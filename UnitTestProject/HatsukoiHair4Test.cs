using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class HatsukoiHair4Test : POHTest<HatsukoiHair4> {
    [TestMethod]
    public void TestMethod1() {
      Input.AppendLine("U U");
      Input.AppendLine("D D");
      Input.AppendLine("L L");
      Input.AppendLine("R R");
      Input.AppendLine("L L");

      Expected.AppendLine("OK");

      Test();
    }

    [TestMethod]
    public void TestMethod2() {
      Input.AppendLine("U U");
      Input.AppendLine("D L");
      Input.AppendLine("R L");
      Input.AppendLine("D U");
      Input.AppendLine("U U");

      Expected.AppendLine("NG");

      Test();
    }
  }
}
