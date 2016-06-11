using System;

namespace PaizaOnlineHackathon8 {

  public class HatsukoiSpecial2 : PaizaOnlineHackathon {

    private string beforeStr;
    private string afterStr;
    private string result;

    protected override void ReadInput() {
      Console.ReadLine();
      beforeStr = Console.ReadLine();
      afterStr = Console.ReadLine();
    }

    protected override void Calclate() {
      foreach (var chr in beforeStr) {
        int idx = afterStr.IndexOf(chr);
        if (idx > -1) {
          afterStr = afterStr.Remove(idx, 1);
        }
      }
      result = afterStr.Length.ToString();
    }

    protected override void Output() {
      Console.WriteLine(result);
    }
  }
}
