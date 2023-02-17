// https://www.codewars.com/kata/55908aad6620c066bc00002a/train/csharp
using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
     return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
  }
}