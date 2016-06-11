using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class HatsukoiHair2Test : POHTest<HatsukoiHair2> {
    [TestMethod]
    public void TestMethod1() {
      Input.AppendLine("3");
      Input.AppendLine("idol");

      Expected.AppendLine("idol");
      Expected.AppendLine("idol");
      Expected.AppendLine("idol");

      Test();
    }

    [TestMethod]
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
