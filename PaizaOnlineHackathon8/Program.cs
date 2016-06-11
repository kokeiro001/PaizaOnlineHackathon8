using System;
using System.Text;
using System.Linq;

namespace PaizaOnlineHackathon8 {
  class Program {
    static void Main(string[] args) {
      PaizaOnlineHackathon obj = new HatsukoiEye3();
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

  public class HatsukoiEye3 : PaizaOnlineHackathon {

    private int input;
    private string result;

    protected override void ReadInput() {
      input = int.Parse(Console.ReadLine());
    }

    protected override void Calclate() {
      int point = (input / 100) + ((input >= 1000) ? 10 : 0);
      result = point.ToString();
    }

    protected override void Output() {
      Console.WriteLine(result);
    }
  }
}
