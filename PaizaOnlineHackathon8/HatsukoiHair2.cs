using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaizaOnlineHackathon8 {
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
