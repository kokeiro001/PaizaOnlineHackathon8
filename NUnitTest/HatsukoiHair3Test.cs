﻿using NUnit.Framework;
using PaizaOnlineHackathon8;

namespace UnitTestProject {

  [TestFixture]
  public class HatsukoiHair3Test : POHTest<HatsukoiHair3> {

    [Test]
    public void TestMethod1() {
      Input.AppendLine("7");
      Expected.AppendLine("lucky");
      Test();
    }

    [Test]
    public void TestMethod2() {
      Input.AppendLine("12");
      Expected.AppendLine("unlucky");
      Test();
    }
  }
}
