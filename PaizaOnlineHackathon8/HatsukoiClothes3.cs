using System;
using System.Linq;

namespace PaizaOnlineHackathon8 {

  // https://paiza.jp/poh/hatsukoi/challenge/hatsukoi_clothes3

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
