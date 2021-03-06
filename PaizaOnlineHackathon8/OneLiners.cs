﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using C = System.Console;
using E = System.Linq.Enumerable;

namespace PaizaOnlineHackathon8 {
  public class HatsukoiHair2_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(string.Join(Environment.NewLine, E.Range(0, int.Parse(C.ReadLine())).Select(_ => "t")).Replace("t", C.ReadLine()));
    }
  }

  public class HatsukoiHair3_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(int.Parse(C.ReadLine()) % 7 == 0 ? "lucky" : "unlucky");
    }
  }

  public class HatsukoiHair4_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(E.Range(0, 5).Select(_ => C.ReadLine().Split(' ')).Count(list => list[0] == list[1]) >= 3 ? "OK" : "NG");
    }
  }

  public class HatsukoiHair5_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(Regex.Replace(string.Join("", E.Range(0, int.Parse(C.ReadLine())).Select(_ => "-")), "^(" + string.Join("", E.Range(0, int.Parse(C.ReadLine()) - 1).Select(_ => "-")) + ")-", "$1+"));
    }
  }

  public class HatsukoiEye2_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(new List<List<int>> { new List<int>(C.ReadLine().Split(' ').Select(str => int.Parse(str))) }.Any(list => list[0] >= list[1]) ? "OK" : "NG");
    }
  }

  public class HatsukoiEye3_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(new int[] { int.Parse(C.ReadLine()) }.Select(num => num / 100 + (num >= 1000 ? 10 : 0)).First());
    }
  }

  public class HatsukoiEye4_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(new List<List<List<int>>> { new List<List<int>> { new List<int> { int.Parse(C.ReadLine()) }, { C.ReadLine().Split(' ').Select(str => int.Parse(str)).OrderBy(n => n).ToList() } } }.Select(list => list[1][list[0][0] / 2]).First());
    }
  }

  public class HatsukoiClothes2_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(new List<List<int>> { C.ReadLine().Split(' ').Select(str => int.Parse(str)).ToList() }.Any(list => list[1] % list[0] == 0) ? "ok" : "ng");
    }
  }

  public class HatsukoiClothes3_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(new List<List<int>> { C.ReadLine().Split(' ').Select(str => int.Parse(str)).ToList() }.Select(list => Math.Max(0, list[0] - list[1])).First());
    }
  }

  public class HatsukoiSpecial2_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(new List<List<List<List<char>>>> { new List<List<List<char>>> { new List<List<char>> { new List<char>(C.ReadLine().Trim()), new List<char>(C.ReadLine().Trim()), new List<char>(C.ReadLine().Trim()) } } }.Select(root => root.First().Skip(1).Take(1).Select(l3 => l3.SingleOrDefault(c => root[0][2].Contains(c) && root[0][2].Remove(c) && false)).Take(1).Select(_ => root[0][2].Count).First()).First());
    }
  }

  public class HatsukoiSpecial5_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(new List<List<int>> { new List<int>() { int.Parse(C.ReadLine()), int.Parse(C.ReadLine()) } }.Select(list => (list[1] / (list[0] * 2)) + ((list[1] % (list[0] * 2)) == 0 ? 0 : 1)).First());
    }
  }

  public class HatsukoiSpecial6_One : IOnePaizaOnlineHackathon {
    public void Run() {
      C.WriteLine(new List<List<int>> { C.ReadLine().Split(' ').Select(str => int.Parse(str)).Concat(C.ReadLine().Split(' ').Select(str => int.Parse(str))).ToList() }.Select(list => (list[0] * list[1]) + ((list[0] / list[2]) + ((((list[0] % list[2]) == 0) ? 0 : 1))) * list[3]).First());
    }
  }
}
