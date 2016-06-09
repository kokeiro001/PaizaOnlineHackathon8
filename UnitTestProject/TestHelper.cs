using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {

  public static class TestHelper {
    public static void Test(PaizaOnlineHackathon obj, StringBuilder input, StringBuilder expected) {
      StringBuilder actual = new StringBuilder();
      using (TextReader tr = new StringReader(input.ToString()))
      using (TextWriter tw = new StringWriter(actual)) {
        Console.SetIn(tr);
        Console.SetOut(tw);

        obj.Run();

        Assert.AreEqual(expected.ToString(), actual.ToString());
      }
    }
  }
}
