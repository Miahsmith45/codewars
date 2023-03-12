// https://www.codewars.com/kata/57a5b0dfcf1fa526bb000118/train/csharp
using System;
using System.Linq;

namespace Solution
{
  public static class Program
  {
    public static int[] distinct(int[] a)
    {
      return a.Distinct().ToArray();
    }
  }
}