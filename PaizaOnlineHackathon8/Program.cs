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
      new HatsukoiHair3_One().Run();
    }
  }

  public interface IOnePaizaOnlineHackathon {
    void Run();
  }

}
