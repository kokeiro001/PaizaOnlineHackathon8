using System;

namespace PaizaOnlineHackathon8 {

  // https://paiza.jp/poh/hatsukoi/challenge/hatsukoi_special5

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
