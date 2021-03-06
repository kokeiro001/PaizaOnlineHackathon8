﻿using System;
using System.IO;
using System.Text;
using NUnit.Framework;

using PaizaOnlineHackathon8;

namespace UnitTestProject {

  [TestFixture]
  public abstract class OnePOHTest<T> where T : IOnePaizaOnlineHackathon, new() {

    private T obj;
    protected StringBuilder Input { get; private set; }
    protected StringBuilder Expected { get; private set; }

    [SetUp]
    public void Initialize() {
      obj = new T();
      Input = new StringBuilder();
      Expected = new StringBuilder();
    }

    public void Test() {
      StringBuilder actual = new StringBuilder();
      using (TextReader tr = new StringReader(Input.ToString()))
      using (TextWriter tw = new StringWriter(actual)) {
        Console.SetIn(tr);
        Console.SetOut(tw);

        obj.Run();

        Assert.AreEqual(Expected.ToString(), actual.ToString());
      }
    }
  }
}
