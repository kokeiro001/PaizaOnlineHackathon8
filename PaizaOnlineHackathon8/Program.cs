using System;
using System.Diagnostics;

namespace PaizaOnlineHackathon8 {
  class Program {
    static void Main(string[] args) {
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
}
