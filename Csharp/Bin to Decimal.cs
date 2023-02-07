// https://www.codewars.com/kata/57a5c31ce298a7e6b7000334/train/csharp

using System;

namespace Solution
{
  public static class Program
  {
    public static int binToDec(string s)
    {
      return Convert.ToInt32(s, 2);
    }
  }
}