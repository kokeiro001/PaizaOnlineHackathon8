using System;
using System.Linq;

namespace PaizaOnlineHackathon8 {

  public class HatsukoiEye2 : PaizaOnlineHackathon {

    private int nokoriZasekiNum;
    private int groupNum;
    private string result;

    protected override void ReadInput() {
      int[] inputs = Console.ReadLine().Split(' ').Select(str => int.Parse(str)).ToArray();
      nokoriZasekiNum = inputs[0];
      groupNum = inputs[1];
    }

    protected override void Calclate() {
      result = nokoriZasekiNum >= groupNum ? "OK" : "NG";
    }

    protected override void Output() {
      Console.WriteLine(result);
    }
  }
}
