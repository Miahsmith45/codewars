// https://www.codewars.com/kata/5875b200d520904a04000003/train/csharp
using System;

public static class Kata
{
  public static int Enough(int cap, int on, int wait) => Math.Max(on + wait - cap, 0);
}