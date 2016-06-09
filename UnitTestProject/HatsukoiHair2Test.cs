using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaOnlineHackathon8;

namespace UnitTestProject {
  [TestClass]
  public class HatsukoiHair2Test {
    [TestMethod]
    public void SampleInut1Test() {
      StringBuilder input = new StringBuilder();
      input.AppendLine("3");
      input.AppendLine("idol");

      StringBuilder expected = new StringBuilder();
      expected.AppendLine("idol");
      expected.AppendLine("idol");
      expected.AppendLine("idol");

      StringBuilder actual = new StringBuilder();
      using (TextReader tr = new StringReader(input.ToString()))
      using (TextWriter tw = new StringWriter(actual)) {
        Console.SetIn(tr);
        Console.SetOut(tw);

        var obj = new HatsukoiHair2();
        obj.Run();

        Assert.AreEqual(expected.ToString(), actual.ToString());
      }
    }

    [TestMethod]
    public void SampleInut2Test() {
      StringBuilder input = new StringBuilder();
      input.AppendLine("10");
      input.AppendLine("dream");

      StringBuilder except = new StringBuilder();
      except.AppendLine("dream");
      except.AppendLine("dream");
      except.AppendLine("dream");
      except.AppendLine("dream");
      except.AppendLine("dream");
      except.AppendLine("dream");
      except.AppendLine("dream");
      except.AppendLine("dream");
      except.AppendLine("dream");
      except.AppendLine("dream");

      StringBuilder result = new StringBuilder();
      using (TextReader tr = new StringReader(input.ToString()))
      using (TextWriter tw = new StringWriter(result)) {
        Console.SetIn(tr);
        Console.SetOut(tw);
        var obj = new HatsukoiHair2();
        obj.Run();
        Assert.AreEqual(except.ToString(), result.ToString());
      }
    }
  }
}
