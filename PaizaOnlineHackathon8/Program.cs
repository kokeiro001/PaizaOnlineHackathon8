using System;
using System.Text;
using System.Linq;

namespace PaizaOnlineHackathon8 {
  class Program {
    static void Main(string[] args) {
      PaizaOnlineHackathon obj = new HatsukoiHair5();
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

  public class HatsukoiHair5 : PaizaOnlineHackathon {

    private int s;
    private int t;
    private string result;

    protected override void ReadInput() {
      s = int.Parse(Console.ReadLine());
      t = int.Parse(Console.ReadLine());
    }

    protected override void Calclate() {
      StringBuilder sb = new StringBuilder();
      for (int i = 1; i <= s; i++) {
        sb.Append(i == t ? "+" : "-");
      }
      result = sb.ToString();
    }

    protected override void Output() {
      Console.WriteLine(result);
    }
  }
}
