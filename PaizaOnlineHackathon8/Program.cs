using System;
using System.Diagnostics;

namespace PaizaOnlineHackathon8 {
  class Program {
    static void Main(string[] args) {
    }
  }

  abstract class PaizaOnlineHackathon {
    protected virtual void Setup() { }
    protected abstract void ReadInput();
    protected abstract void Calclate();
    protected abstract void Output();

    [Conditional("LOCAL_DEBUG")]
    private void ChangeInputFromLocalFile(string fname) {
      Console.SetIn(new System.IO.StreamReader(fname));
    }

    public void Run() {
      Setup();
      ReadInput();
      Calclate();
      Output();
    }
  }
}
