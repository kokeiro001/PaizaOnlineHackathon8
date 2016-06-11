using System;
using System.Linq;

namespace PaizaOnlineHackathon8 {

  // https://paiza.jp/poh/hatsukoi/challenge/hatsukoi_special6

  public class HatsukoiSpecial6 : PaizaOnlineHackathon {

    private int funNum;
    private int paperCost;
    private int writablePaperCount;
    private int penCost;
    private string result;

    protected override void ReadInput() {
      var line1 = Console.ReadLine().Split(' ').Select(str => int.Parse(str)).ToArray();
      funNum = line1[0];
      paperCost = line1[1];

      var line2 = Console.ReadLine().Split(' ').Select(str => int.Parse(str)).ToArray();
      writablePaperCount = line2[0];
      penCost = line2[1];
    }

    protected override void Calclate() {
      int totalPaperCost = funNum * paperCost;
      int totalPenNum = (funNum / writablePaperCount);
      if (funNum % writablePaperCount != 0) {
        totalPenNum++;
      }
      int totalPenCost = totalPenNum * penCost;

      result = (totalPaperCost + totalPenCost).ToString();
    }

    protected override void Output() {
      Console.WriteLine(result);
    }
  }
}
