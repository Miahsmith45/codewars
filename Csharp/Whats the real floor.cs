// https://www.codewars.com/kata/574b3b1599d8f897470018f6/train/csharp
using System;

public static class Kata
{
  public static int GetRealFloor(int n)
  {
    if(n > 12) return n-2;
    if(n > 0) return n-1;
    return n;
  }
}