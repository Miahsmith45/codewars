// https://www.codewars.com/kata/56676e8fabd2d1ff3000000c/train/csharp
using System;
public class Kata
{
  public static string FindNeedle(object[] haystack)
  {
 return $"found the needle at position {Array.IndexOf(haystack, "needle")}";
  }
}