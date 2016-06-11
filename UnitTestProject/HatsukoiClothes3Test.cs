using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class HatsukoiClothes3Test : POHTest<HatsukoiClothes3> {
    [TestMethod]
    public void TestMethod1() {
      Input.AppendLine("5 2");
      Expected.AppendLine("3");
      Test();
    }

    [TestMethod]
    public void TestMethod2() {
      Input.AppendLine("10 10");
      Expected.AppendLine("0");
      Test();
    }

    [TestMethod]
    public void TestMethod3() {
      Input.AppendLine("2 4");
      Expected.AppendLine("0");
      Test();
    }
  }
}
