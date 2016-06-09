using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class HatsukoiHair3Test {

    private HatsukoiHair3 obj;

    [TestInitialize]
    public void Initialize() {
      obj = new HatsukoiHair3();
    }

    [TestMethod]
    public void SampleInut1Test() {
      StringBuilder input = new StringBuilder();
      input.AppendLine("7");

      StringBuilder expected = new StringBuilder();
      expected.AppendLine("lucky");

      TestHelper.Test(obj, input, expected);
    }
    [TestMethod]
    public void SampleInut2Test() {
      StringBuilder input = new StringBuilder();
      input.AppendLine("12");

      StringBuilder expected = new StringBuilder();
      expected.AppendLine("unlucky");

      TestHelper.Test(obj, input, expected);
    }
  }
}
