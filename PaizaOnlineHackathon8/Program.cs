using System;
using System.Text;
using System.Linq;

namespace PaizaOnlineHackathon8 {
  class Program {
    static void Main(string[] args) {
      PaizaOnlineHackathon obj = new HatsukoiEye2();
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

  public class HatsukoiEye2 : PaizaOnlineHackathon {

    private int nokoriZasekiNum;
    private int groupNum;
    private string result;

    protected override void ReadInput() {
      int[] inputs = Console.ReadLine().Split(' ').Select(str => int.Parse(str)).ToArray();
      nokoriZasekiNum = inputs[0];
      groupNum = inputs[1];
    }

    protected override void Calclate() {
      result = nokoriZasekiNum >= groupNum ? "OK" : "NG";
    }

    protected override void Output() {
      Console.WriteLine(result);
    }
  }
}
