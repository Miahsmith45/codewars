// https://www.codewars.com/kata/5a00e05cc374cb34d100000d/train/csharp
using System;
using System.Linq;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    return Enumerable.Range(1, n).Reverse().ToArray();
  }
}