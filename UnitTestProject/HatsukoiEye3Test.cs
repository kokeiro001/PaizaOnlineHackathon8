using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class HatsukoiEye3Test :POHTest<HatsukoiEye3> {
    [TestMethod]
    public void TestMethod1() {
      Input.AppendLine("850");
      Expected.AppendLine("8");
      Test();
    }

    [TestMethod]
    public void TestMethod2() {
      Input.AppendLine("1230");
      Expected.AppendLine("22");
      Test();
    }
  }
}
