using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PaizaOnlineHackathon8 {
  class Program {
    static void Main(string[] args) {
      PaizaOnlineHackathon obj = new HatsukoiEye4();
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

  public class HatsukoiEye4 : PaizaOnlineHackathon {

    private List<int> numbers = new List<int>();
    string result;

    protected override void ReadInput() {
      int n = int.Parse(Console.ReadLine());
      numbers = Console.ReadLine().Split(' ').Select(numStr => int.Parse(numStr)).ToList();
    }

    protected override void Calclate() {
      numbers.Sort();
      result = numbers[numbers.Count / 2].ToString();
    }

    protected override void Output() {
      Console.WriteLine(result);
    }
  }
}
