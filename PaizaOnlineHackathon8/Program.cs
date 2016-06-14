using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using C = System.Console;
using E = System.Linq.Enumerable;
namespace PaizaOnlineHackathon8 {
  class Program {
    static void Main(string[] args) {
      new HatsukoiHair2_One().Run();
    }
  }

  public interface IOnePaizaOnlineHackathon {
    void Run();
  }

  public class HatsukoiHair2_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(string.Join("\r\n", E.Range(0, int.Parse(C.ReadLine())).Select(_ => "t")).Replace("t", C.ReadLine()));
    }
  }
}
