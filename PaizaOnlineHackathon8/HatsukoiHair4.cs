using System;
using System.Linq;

namespace PaizaOnlineHackathon8 {

  public class HatsukoiHair4 : PaizaOnlineHackathon {

    class Input {
      public string d { get; set; }
      public string e { get; set; }
    }

    private Input[] inputs = new Input[5];

    protected override void ReadInput() {
      for (int i = 0; i < inputs.Length; i++) {
        var line = Console.ReadLine().Split(' ');
        inputs[i] = new Input();
        inputs[i].d = line[0];
        inputs[i].e = line[1];
      }
    }

    protected override void Calclate() {
    }

    protected override void Output() {
      Console.WriteLine(inputs.Count(input => input.d == input.e) >= 3 ? "OK" : "NG");
    }
  }
}
