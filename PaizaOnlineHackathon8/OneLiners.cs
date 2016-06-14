using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = System.Console;
using E = System.Linq.Enumerable;

namespace PaizaOnlineHackathon8 {
  public class HatsukoiHair2_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(string.Join("\r\n", E.Range(0, int.Parse(C.ReadLine())).Select(_ => "t")).Replace("t", C.ReadLine()));
    }
  }


  public class HatsukoiHair3_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(int.Parse(C.ReadLine()) % 7 == 0 ? "lucky" : "unlucky");
    }
  }
}
