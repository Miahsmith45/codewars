// https://www.codewars.com/kata/55ecd718f46fba02e5000029/train/csharp
using System.Collections.Generic;

public static class Kata
{
  public static int[] Between(int a, int b)
  {
    var result = new List<int>();
    for (var i = a; i <= b; i++)
    {
        result.Add(i);
    }
    return result.ToArray();
  }
}