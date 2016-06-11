using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class HatsukoiHair3Test : POHTest<HatsukoiHair3> {

    [TestMethod]
    public void SampleInut1Test() {
      Input.AppendLine("7");
      Expected.AppendLine("lucky");
      Test();
    }
    [TestMethod]
    public void SampleInut2Test() {
      Input.AppendLine("12");
      Expected.AppendLine("unlucky");
      Test();
    }
  }
}
