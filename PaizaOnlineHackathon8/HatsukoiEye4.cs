using System;
using System.Collections.Generic;
using System.Linq;

namespace PaizaOnlineHackathon8 {

  public class HatsukoiEye4 : PaizaOnlineHackathon {

    private List<int> numbers = new List<int>();
    string result;

    protected override void ReadInput() {
      int n = int.Parse(Console.ReadLine());
      numbers = Console.ReadLine().Split(' ').Select(numStr => int.Parse(numStr)).ToList();
    }

    protected override void Calclate() {
      numbers.Sort();
      result = numbers[numbers.Count / 2].ToString();
    }

    protected override void Output() {
      Console.WriteLine(result);
    }
  }
}
