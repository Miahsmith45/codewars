// https://www.codewars.com/kata/5704aea738428f4d30000914/train/csharp
using System;
public class Kata
{
  public static string TripleTrouble(string one, string two, string three)
  {
    string res = "";
    for(var i = 0; i < one.Length; i++)
      {
      res += $"{one[i]}{two[i]}{three[i]}";
    }
    return res;
  }
}