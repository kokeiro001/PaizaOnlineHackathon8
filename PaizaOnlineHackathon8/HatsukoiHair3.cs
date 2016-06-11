using System;

namespace PaizaOnlineHackathon8 {

  public class HatsukoiHair3 : PaizaOnlineHackathon {

    private int n;

    protected override void ReadInput() {
      n = int.Parse(Console.ReadLine());
    }

    protected override void Calclate() {
    }

    protected override void Output() {
      Console.WriteLine((n % 7) == 0 ? "lucky" : "unlucky");
    }
  }
}
