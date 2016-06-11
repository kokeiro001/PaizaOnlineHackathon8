using System;

namespace PaizaOnlineHackathon8 {

  // https://paiza.jp/poh/hatsukoi/challenge/hatsukoi_hair2

  public class HatsukoiHair2 : PaizaOnlineHackathon {

    private int n;
    private string word;

    protected override void ReadInput() {
      n = int.Parse(Console.ReadLine());
      word = Console.ReadLine().Trim();
    }

    protected override void Calclate() {
    }

    protected override void Output() {
      for (int i = 0; i < n; i++) {
        Console.WriteLine(word);
      }
    }
  }
}
