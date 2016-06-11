using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PaizaOnlineHackathon8 {
  class Program {
    static void Main(string[] args) {
      PaizaOnlineHackathon obj = new HatsukoiSpecial5();
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

  public class HatsukoiSpecial5 : PaizaOnlineHackathon {

    private int workPerDay;
    private int totalEvent;
    private string result;

    protected override void ReadInput() {
      workPerDay = int.Parse(Console.ReadLine());
      totalEvent = int.Parse(Console.ReadLine());
    }

    protected override void Calclate() {
      int nokoriEvent = totalEvent;
      int week = 0;
      do {
        week++;
        nokoriEvent -= workPerDay * 2;
      } while (nokoriEvent > 0);

      result = week.ToString();
    }

    protected override void Output() {
      Console.WriteLine(result);
    }
  }
}
