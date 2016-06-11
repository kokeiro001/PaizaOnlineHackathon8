using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PaizaOnlineHackathon8 {
  class Program {
    static void Main(string[] args) {
      PaizaOnlineHackathon obj = new HatsukoiSpecial2();
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

  public class HatsukoiSpecial2 : PaizaOnlineHackathon {

    private string beforeStr;
    private string afterStr;
    private string result;

    protected override void ReadInput() {
      Console.ReadLine();
      beforeStr = Console.ReadLine();
      afterStr = Console.ReadLine();
    }

    protected override void Calclate() {
      foreach (var chr in beforeStr) {
        int idx = afterStr.IndexOf(chr);
        if (idx > -1) {
          afterStr = afterStr.Remove(idx, 1);
        }
      }
      result = afterStr.Length.ToString();
    }

    protected override void Output() {
      Console.WriteLine(result);
    }
  }
}
