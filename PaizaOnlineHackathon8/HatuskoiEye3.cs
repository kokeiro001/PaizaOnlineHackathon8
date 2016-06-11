using System;

namespace PaizaOnlineHackathon8 {

  public class HatsukoiEye3 : PaizaOnlineHackathon {

    private int input;
    private string result;

    protected override void ReadInput() {
      input = int.Parse(Console.ReadLine());
    }

    protected override void Calclate() {
      int point = (input / 100) + ((input >= 1000) ? 10 : 0);
      result = point.ToString();
    }

    protected override void Output() {
      Console.WriteLine(result);
    }
  }
}
