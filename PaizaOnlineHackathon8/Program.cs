using System;
using System.Diagnostics;

namespace PaizaOnlineHackathon8 {
  class Program {
    static void Main(string[] args) {
      PaizaOnlineHackathon obj = new HatsukoiHair3();
      obj.Run();
    }
  }

  public abstract class PaizaOnlineHackathon {
    protected abstract void ReadInput();
    protected abstract void Calclate();
    protected abstract void Output();

    public void Run() {
      ReadInput();
      Calclate();
      Output();
    }
  }

  public class HatsukoiHair4 : PaizaOnlineHackathon {
    protected override void Calclate() {
      throw new NotImplementedException();
    }

    protected override void Output() {
      throw new NotImplementedException();
    }

    protected override void ReadInput() {
      throw new NotImplementedException();
    }
  }
}
