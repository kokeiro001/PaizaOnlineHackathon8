using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PaizaOnlineHackathon8 {
  class Program {
    static void Main(string[] args) {
      PaizaOnlineHackathon obj = new HatsukoiClothes3();
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

  public class HatsukoiClothes3 : PaizaOnlineHackathon {

    private int forward;
    private int back;
    private string result;

    protected override void ReadInput() {
      var inputs = Console.ReadLine().Split(' ').Select(str => int.Parse(str)).ToArray();
      forward = inputs[0];
      back = inputs[1];
    }

    protected override void Calclate() {
      result = Math.Max(0, forward - back).ToString();
    }

    protected override void Output() {
      Console.WriteLine(result);
    }
  }
}
