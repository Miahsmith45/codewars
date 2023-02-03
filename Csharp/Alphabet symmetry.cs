// https://www.codewars.com/kata/59d9ff9f7905dfeed50000b0/train/csharp
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static List<int> Solve(List<string> arr)
  {
    return arr.Select(s => s.Where((c, i) => c % 32 == i + 1).Count()).ToList();
  }
}