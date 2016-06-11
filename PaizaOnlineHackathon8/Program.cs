using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PaizaOnlineHackathon8 {
  class Program {
    static void Main(string[] args) {
      PaizaOnlineHackathon obj = new HatsukoiClothes2();
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

  public class HatsukoiClothes2 : PaizaOnlineHackathon {

    private int staffNum;
    private int candyNum;
    private string result;

    protected override void ReadInput() {
      var inputs = Console.ReadLine().Split(' ').Select(str => int.Parse(str)).ToArray();
      staffNum = inputs[0];
      candyNum = inputs[1];
    }

    protected override void Calclate() {
      result = (candyNum % staffNum == 0) ? "ok" : "ng";
    }

    protected override void Output() {
      Console.WriteLine(result);
    }
  }
}
