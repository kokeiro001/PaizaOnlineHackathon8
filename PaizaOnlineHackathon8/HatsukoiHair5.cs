using System;
using System.Text;

namespace PaizaOnlineHackathon8 {
  public class HatsukoiHair5 : PaizaOnlineHackathon {

    private int s;
    private int t;
    private string result;

    protected override void ReadInput() {
      s = int.Parse(Console.ReadLine());
      t = int.Parse(Console.ReadLine());
    }

    protected override void Calclate() {
      StringBuilder sb = new StringBuilder();
      for (int i = 1; i <= s; i++) {
        sb.Append(i == t ? "+" : "-");
      }
      result = sb.ToString();
    }

    protected override void Output() {
      Console.WriteLine(result);
    }
  }
}
